using Core_Assingment_Api.Model;
using CoreAssingment_Api_BAL_DAL.Repository_Pattern;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shopping_cart_api.Data;
using Shopping_cart_api.Models_product_admin;
using System;
using System.Data;

namespace Shopping_cart_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public readonly IMyCrud<Product> _product;
        public readonly IMyCrud<ProductDTO> _image;
        public readonly IMyCrud<Order> _order;
        public readonly ApplicationDbContext _context;

        public OrderController(IMyCrud<Product> product, IMyCrud<Order> order, ApplicationDbContext context, IMyCrud<ProductDTO> image)
        {
            _product = product;
            _order = order;
            _context = context;
            _image = image;
        }

        [Authorize(Roles = "User,Admin")]
        [HttpGet("GetProduct")]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return Ok(await _product.GetAll());
        }


        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<List<Product>>> GetById(int id)
        {
            return Ok(await _product.GetById(id));
        }
        [HttpGet("GetimagesById/{id}")]
        public async Task<ActionResult<List<string>>> GetimagesById(int id)
        {
            try
            {
             
                var imageUrls = await _image.GetImagesByProductId(id);

                return Ok(imageUrls);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                Console.WriteLine(ex.Message);
                return StatusCode(500, "Internal Server Error");
            }
        }


        [HttpPost("AddProduct")]
        [Authorize(Roles = "Admin")]

        public async Task<ActionResult<List<Product>>> AddProduct([FromBody] Product product)
        {
            _product.Insert(product);        
            _product.Save();
            return Ok(product);
        }
        [HttpPost("AddImage")]
        public async Task<ActionResult<List<ProductDTO>>> AddImage(ProductInputModal products)
        {
            ProductDTO dto = new ProductDTO
            {
                ProductId = products.ProductId,
                URL = products.URL
            };

            if (dto.ProductId != 0) // or any other valid default value
            {
                // Check if the number of existing images for the product is less than 3
                if (_image.GetImagesCountForProduct(dto.ProductId) < 3)
                {
                    _image.Insert(dto);
                    _image.Save();
                    return Ok(products);
                }
                else
                {
                    return BadRequest("Cannot add more than 3 images for the given ProductId");
                }
            }
            else
            {
                return BadRequest("Invalid ProductId");
            }
        }


        [HttpDelete("Delete/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<List<Product>>> Delete(int id)
        {
            if (id < 1)
            {
                return BadRequest("Invalid id token");
            }
            _product.Delete(id);
            _product.Save();
            return Ok(await _product.GetAll());

        }
        [HttpPut("Update")]
        //[Authorize(Roles = "Admin")]
        public async Task<ActionResult<List<Product>>> Update(Product product)
        {
            if (product.Id < 1)
            {
                return BadRequest("Invalid id token");
            }
            _product.Update(product);
            _product.Save();
            return Ok(await _product.GetAll());
        }
        [HttpGet("GetOrder")]
        //[Authorize(Roles = "Admin")]
        public async Task<ActionResult<List<Order>>> GetOrder()
        {
            return Ok(await _order.GetAll());
        }

        [HttpPost("PlaceOrder")]
        public async Task<ActionResult<List<Order>>> PlaceOrder(Order orders)
        {
            try
            {
                
                var product = await _product.GetById(orders.productId);

                if (product == null)
                {
                    return BadRequest("Invalid Product ID");
                }

                
                if (orders.quantity <= product.Stock)
                {
                    _order.Insert(orders);
                    _order.Save();

                    
                    product.Stock -= orders.quantity;
                    _product.Update(product);
                    _product.Save();

                    return Ok(orders);
                }
                else
                {
                    return BadRequest("Ordered quantity exceeds available stock");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpGet("Getorderbyid/{id}")]
        public async Task<ActionResult<List<Order>>> GetOrders(string id)
        {
            return Ok(await _order.GetByIdd(id));
        }
        [HttpPut("updateimagebyid/{id}")]
        public async Task<ActionResult<List<Order>>> UpdateImageById(string id, string newid)
        {
            try
            {
                
                
                await _image.UpdateUrl(id, newid);
                _image.Save();

                
                return Ok(await _order.GetAll()); 
            }
            catch (Exception ex)
            {
                
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

    }
}

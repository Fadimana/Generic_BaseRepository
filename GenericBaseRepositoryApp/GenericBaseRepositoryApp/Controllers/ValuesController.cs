using Business.Layer.Interface;
using DataAccess.Layer.Contrete;
using DataAccess.Layer.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericBaseRepositoryApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IGenericBusiness<Customer> _customer;
        private readonly IGenericBusiness<Product> _product;

        public ValuesController(IGenericBusiness<Customer> genericBusiness1, IGenericBusiness<Product> genericBusiness2)
        {
            _customer = genericBusiness1;
            _product = genericBusiness2;
        }


        [HttpGet("customer")]
        public async Task<IActionResult> GetAll()
        {
            var a = await _customer.GetAll();
            return Ok(a);

        }
        [HttpGet("Product")]
        public async Task<IActionResult> GetAll2()
        {
            var a = await _product.GetAll();
            return Ok(a);
        }

        [HttpGet("GetByIdProduct/{id1}")]
        public async Task<IActionResult> GetById(int id1)
        {
            var ıd = await _product.GetById(id1);
            return Ok(ıd);

        }
        [HttpGet("GetByIdCustomer{id}")]
        public async Task<IActionResult> GetById1(int id)
        {
            var ıd = await _customer.GetById(id);
            return Ok(ıd);

        }
        [HttpPost("CreateProduct")]
        public async Task<IActionResult> Post(Product product)
        {
            var c = await _product.Create(product);
            return Ok(c);
        }
        [HttpPost("CreateCustomer")]
        public async Task<IActionResult> Post1(Customer customer)
        {
            var c = await _customer.Create(customer);
            return Ok(c);
        }
        [HttpDelete("DeleteCustomer/{id3}")]
        public async Task<IActionResult> Delete(int id3)
        {
            var d = _customer.DeleteById(id3);
            return Ok(d);
        }
        [HttpDelete("DeleteProduct/{id2}")]
        public async Task<IActionResult> Delete1(int id2)
        {
            var d = _product.DeleteById(id2);
            return Ok(d);
        }

        [HttpPut("UpdateProduct")]
        public async Task<IActionResult> Put(Product product)
        {
            var up = await _product.Update(product);
            return Ok(up);
        }
        [HttpPut("UpdateCustomer")]
        public async Task<IActionResult> Put1(Customer customer)
        {
            var up = await _customer.Update(customer);
            return Ok(up);
        }





    }
}

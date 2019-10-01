﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataContext;
using FactoryShopping.Models.FactoryShoppingModel;

namespace FactoryShopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Address_CheckoutController : ControllerBase
    {
        private readonly FactoryShoppingDataContext _context;

        public Address_CheckoutController(FactoryShoppingDataContext context)
        {
            _context = context;
        }

        // GET: api/Address_Checkout
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Address_Checkout>>> Getaddresses()
        {
            return await _context.addresses.ToListAsync();
        }

        // GET: api/Address_Checkout/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Address_Checkout>> GetAddress_Checkout(int id)
        {
            var address_Checkout = await _context.addresses.FindAsync(id);

            if (address_Checkout == null)
            {
                return NotFound();
            }

            return address_Checkout;
        }

        // PUT: api/Address_Checkout/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAddress_Checkout(int id, Address_Checkout address_Checkout)
        {
            if (id != address_Checkout.AddressId)
            {
                return BadRequest();
            }

            _context.Entry(address_Checkout).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Address_CheckoutExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Address_Checkout
        [HttpPost]
        public async Task<ActionResult<Address_Checkout>> PostAddress_Checkout(Address_Checkout address_Checkout)
        {
            _context.addresses.Add(address_Checkout);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAddress_Checkout", new { id = address_Checkout.AddressId }, address_Checkout);
        }

        // DELETE: api/Address_Checkout/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Address_Checkout>> DeleteAddress_Checkout(int id)
        {
            var address_Checkout = await _context.addresses.FindAsync(id);
            if (address_Checkout == null)
            {
                return NotFound();
            }

            _context.addresses.Remove(address_Checkout);
            await _context.SaveChangesAsync();

            return address_Checkout;
        }

        private bool Address_CheckoutExists(int id)
        {
            return _context.addresses.Any(e => e.AddressId == id);
        }
    }
}

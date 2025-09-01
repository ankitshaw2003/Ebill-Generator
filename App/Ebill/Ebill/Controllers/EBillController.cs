using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ebill.Models;

namespace Ebill.Controllers
{
    public class EBillController : Controller
    {
        // GET: EBill
        EbillDBEntities db = new EbillDBEntities();
        public ActionResult Index()
        {
            BillList detail = new BillList();
            detail.BillDetails = db.tbl_BillDetails.ToList();
            return View(detail);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(BillDetail details)
        {
            int totalAmount = 0;
            var CreateDetails = db.tbl_BillDetails.Create();
            CreateDetails.CustomerName = details.CustomerName;
            CreateDetails.Address = details.Address;
            CreateDetails.MobileNumber = details.MobileNumber;
            CreateDetails.TotalAmount = 0;

            db.tbl_BillDetails.Add(CreateDetails);
            db.SaveChanges();

            foreach (var item in details.Items)
            {
                totalAmount += (item.Price * item.Quantity);

                var CreateItems = db.tbl_BillItems.Create();
                CreateItems.BillId = CreateDetails.Id;
                CreateItems.Price = item.Price;
                CreateItems.Quantity = item.Quantity;
                CreateItems.ProductName = item.ProductName;

                db.tbl_BillItems.Add(CreateItems);
            }
            db.SaveChanges();

            CreateDetails.TotalAmount = totalAmount;
            db.SaveChanges();

            return View();
        }

        public ActionResult CreateItem(Items item)
        {
            return PartialView("_CreateItem",item);
        }
        public ActionResult ViewBill(int Id)
        {
            BillList detail = new BillList();
            detail.BillDetails = db.tbl_BillDetails.Where(b => b.Id == Id).ToList();
            detail.BillItems = db.tbl_BillItems.Where(x => x.BillId == Id).ToList();
            return View(detail);
        }
    }
}
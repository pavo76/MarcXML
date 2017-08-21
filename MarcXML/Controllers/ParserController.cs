using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MarcXML.Models;
using MarcXML.HelperClass;

namespace MarcXML.Controllers
{
    public class ParserController : Controller
    {
        private MARCXML db = new MARCXML();

        // GET: Parser
        public ActionResult Index()
        {
            return View(db.MARC_XML_.ToList());
        }

        // GET: Parser/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MARC_XML_Data mARC_XML_Data = db.MARC_XML_.Find(id);
            if (mARC_XML_Data == null)
            {
                return HttpNotFound();
            }
            Dict dict = new Dict();
            dict.Dictionary = Parser.Parse(mARC_XML_Data.XML);
            tbl_Parsed_Data data = new tbl_Parsed_Data();
            List<string> dataProps = new List<string>();
            foreach (var item in data.GetType().GetProperties().ToList())
            {
                dataProps.Add(item.Name);
            }

            foreach (var item in dict.Dictionary)
            {
                if (dataProps.Contains(item.Key))
                {
                    data.GetType().GetProperty(item.Key).SetValue(data, item.Value);
                }
            }
            Parsed_DataController controller = new Parsed_DataController();
            controller.ControllerContext = ControllerContext;
            controller.Create(data);
            return View(dict);
        }

        public ActionResult CreateParsed(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MARC_XML_Data mARC_XML_Data = db.MARC_XML_.Find(id);
            if (mARC_XML_Data == null)
            {
                return HttpNotFound();
            }
            Dict dict = new Dict();
            dict.Dictionary = Parser.Parse(mARC_XML_Data.XML);
            tbl_Parsed_Data data = new tbl_Parsed_Data();
            List<string> dataProps = new List<string>();
            foreach (var item in data.GetType().GetProperties().ToList())
            {
                dataProps.Add(item.Name);
            }

            foreach (var item in dict.Dictionary)
            {
                if (dataProps.Contains(item.Key))
                {
                    data.GetType().GetProperty(item.Key).SetValue(data, item.Value);
                }
            }
            Parsed_DataController controller = new Parsed_DataController();
            controller.ControllerContext = ControllerContext;
            controller.Create(data);
            return RedirectToAction("Index", "Parsed_Data");
        }

        // GET: Parser/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Parser/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ID_Broj_Knjige,XML,Datum_preuzimanja")] MARC_XML_Data mARC_XML_Data)
        {
            if (ModelState.IsValid)
            {
                db.MARC_XML_.Add(mARC_XML_Data);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mARC_XML_Data);
        }

        // GET: Parser/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MARC_XML_Data mARC_XML_Data = db.MARC_XML_.Find(id);
            if (mARC_XML_Data == null)
            {
                return HttpNotFound();
            }
            return View(mARC_XML_Data);
        }

        // POST: Parser/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ID_Broj_Knjige,XML,Datum_preuzimanja")] MARC_XML_Data mARC_XML_Data)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mARC_XML_Data).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mARC_XML_Data);
        }

        // GET: Parser/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MARC_XML_Data mARC_XML_Data = db.MARC_XML_.Find(id);
            if (mARC_XML_Data == null)
            {
                return HttpNotFound();
            }
            return View(mARC_XML_Data);
        }

        // POST: Parser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MARC_XML_Data mARC_XML_Data = db.MARC_XML_.Find(id);
            db.MARC_XML_.Remove(mARC_XML_Data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

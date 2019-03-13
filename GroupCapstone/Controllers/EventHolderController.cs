﻿using GroupCapstone.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupCapstone.Controllers
{
    public class EventHolderController : Controller
    {
        private ApplicationDbContext db;
        public EventHolderController()
        {
            db = new ApplicationDbContext();
        }
        // GET: EventHolder
        public ActionResult Index()
        {
            return View();
        }

        // GET: EventHolder/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EventHolder/Create
        public ActionResult Create()
        {
            EventHolder eventHolder = new EventHolder();
            return View(eventHolder);
        }

        // POST: EventHolder/Create
        [HttpPost]
        public ActionResult Create(EventHolder eventHolder)
        {
            try
            {
                // TODO: Add insert logic here
                db.eventHolders.Add(eventHolder);
                eventHolder.ApplicationUserId = User.Identity.GetUserId();
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EventHolder/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EventHolder/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EventHolder/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EventHolder/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

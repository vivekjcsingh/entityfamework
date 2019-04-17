﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testentityframework.Models;

namespace testentityframework.Controllers
{
	public class studentdetailsController : Controller
	{
		TEF_StudentsEntities db = new TEF_StudentsEntities();
		// GET: studentdetails
		public ActionResult Index()
		{
			return View(db.Students.ToList());
		}

		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Create(Student student)
		{
			if (ModelState.IsValid)
			{
				db.Students.Add(student);
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			else
			{
				return View();
			}


		}

		public ActionResult Edit(int? ID)
		{
			Student student = db.Students.Find(ID);
			return View(student);
		}

		[HttpPost]
		public ActionResult Edit(Student student)
		{
			if (ModelState.IsValid)
			{
				db.Entry(student).State = EntityState.Modified;
				db.SaveChanges();
			}
			return RedirectToAction("Index");
		}

		public ActionResult Delete(int? id)
		{
			Student student = db.Students.Find(id);
			if (student == null)
			{
				return HttpNotFound();
			}
			else
			{
				db.Students.Remove(student);
				db.SaveChanges();
				return RedirectToAction("Index");
			}
		}
	}
}
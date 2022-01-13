using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using panel_sms.Models;
using entity;
namespace panel_sms.Controllers
{
    public class HomeController : Controller
    {
        public readonly connect _connect;
       
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,connect connect)
        {
            _logger = logger;
            _connect=connect;

        }

        public IActionResult Index()
        {
        
            return View();
        }
        public IActionResult add(vm_student f)
        {
            student st=new student();
            st.Name=f.Name;
            st.Family=f.Family;
            st.Mobile=f.Mobile;
            _connect.students.Add(st);
            _connect.SaveChanges();
            return RedirectToAction("index");
        }
         public IActionResult update(student st)
        {
            var select=_connect.students.Where(b=>b.id==st.id).FirstOrDefault();
            select.Name=st.Name;
            select.Name=st.Family;
            select.Name=st.Mobile;
            _connect.Update(select);
            _connect.SaveChanges();
            return RedirectToAction("privacy");
        }
         public IActionResult delete(int id)
        {
             var select=_connect.students.Where(b=>b.id==id).FirstOrDefault();
            
            _connect.students.Remove(select);
            _connect.SaveChanges();
            return RedirectToAction("privacy");
        }

        public IActionResult Privacy()
        {

            var s=_connect.students.ToList();
            // List<vm_student> d=new List<vm_student>();
            // foreach (var item in s)
            // {
            //     vm_student g=new vm_student();
            //      g.Name=item.Name;
            //      g.Family=item.Family;
            //     d.Add(g);

              
            // }
            
            return View(s);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

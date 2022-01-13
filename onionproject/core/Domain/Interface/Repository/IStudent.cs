using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Domain.Interface.Repository
{
    public interface IStudent
    {
        bool Addstudent (Mstudent st);
        bool deletstudent (int Id);
        bool Editstudet (Mstudent st);
        List<Mstudent> Getallstudent();
        List<Mstudent> Findstudent (string Name,string Family);
        


    }
}
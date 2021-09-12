using System;
using System.Collections.Generic;
using System.Text;
using UngDungDocBao.Models;

namespace UngDungDocBao.IO
{
    public interface INewsRepository
    {
        List<Publisher> GetNews();
        void Save(List<Publisher> publishers);
    }
}

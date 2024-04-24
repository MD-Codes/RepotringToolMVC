using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepotringToolMVC.Models
{
    public interface ILoadFiles<T>
    {
        T LoadFile(string filename);
    }
}

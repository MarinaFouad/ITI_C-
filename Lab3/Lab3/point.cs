using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class point<Gen>
    {
        public Gen X {  get; set; }
        public Gen Y { get; set; }
        public point(Gen x , Gen y) {  X = x; Y = y; }

        
    }
}

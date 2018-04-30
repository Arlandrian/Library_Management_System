using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Yonetim
{
    public class AkilliKart
    {

        private float bakiye;
        private string id;

        public AkilliKart(float bakiye, string id)
        {
            this.bakiye = bakiye;
            this.id = id;
        }

        public void setBakiye(float bakiye)
        {
            if (bakiye < 0)
            {
                //YETERSİZ BAKİYE
            }
            else
            {
                this.bakiye = bakiye;
            }
            
        }

        public float getBakiye()
        {
            return bakiye;
        }

    }
}

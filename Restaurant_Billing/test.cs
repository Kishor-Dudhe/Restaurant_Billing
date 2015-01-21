using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Restaurant_Billing
{
    [TestFixture]
        public class test
        {
            Program p=new Program();
            [Test]
            public void testbill()
            {
                

                int i=p.bill(1,2);
                
                Assert.AreEqual(100m, i);
                
            }

            [Test]
            public void testedit()
            {
                int j=p.edit(1);

            }
        }
    }


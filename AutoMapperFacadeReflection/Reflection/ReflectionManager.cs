﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace AutoMapperFacadeReflection.Reflection
{
    public class ReflectionManager
    {
        public void XPathReader()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ReflectionConfiguration.xml");

            foreach(XmlNode types in doc.SelectNodes("//Types"))
            {
                var reflectionVar = types.SelectSingleNode("Type");
                string varEleph = reflectionVar.InnerText;
                varEleph = varEleph.Trim();

                Assembly asm = typeof(ReflectionManager).Assembly;
                Type elephantType = asm.GetType(varEleph);

                var elephant = Activator.CreateInstance(elephantType, "Loxodonta africana", 7650, 396);
                Console.WriteLine(string.Format(@"{0}, {1}, {2}", ((ReflectionElephantModel)elephant).ScientificName, ((ReflectionElephantModel)elephant).Weight, ((ReflectionElephantModel)elephant).Height));
                //Console.WriteLine(className.InnerText);
            }
        }
    }
}

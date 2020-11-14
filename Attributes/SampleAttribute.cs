using System;
using System.Collections.Generic;
using System.Text;

namespace Attributes
{
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
  class SampleAttribute : Attribute
  {
    [Sample]
    public string Name { get; set; }
    public void Version() { }
  }
}
 
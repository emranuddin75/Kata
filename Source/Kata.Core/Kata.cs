using System;
using System.Linq;

namespace Kata.Core
{
    public abstract class Kata : IKata
    {
        protected string[] Lines { get; set; }

        public abstract string[] Create();

        public string OutPut()
        {
            return string.Join(Environment.NewLine, Lines.Where(s => !string.IsNullOrEmpty(s)));
        }
    }
}

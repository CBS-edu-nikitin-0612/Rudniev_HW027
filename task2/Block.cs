using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Block
    {
        private int a, b, c, d;

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }
        public int D { get => d; set => d = value; }

        public Block() : this(10, 10, 10, 10) { }
        public Block(int a) : this(a, 10, 10, 10) { }
        public Block(int a, int b) : this(a, b, 10, 10) { }
        public Block(int a, int b, int c) : this(a, b, c, 10) { }
        public Block(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public override string ToString()
            => $"{nameof(Block)}: a = {this.a}, b = {this.b}, c = {this.c}, d = {this.d}.";

        public override bool Equals(object obj)
        {
            if (obj == null ^ !(obj is Block))
                return false;
            Block block = obj as Block;
            return this.A == block.A && this.B == block.B && this.C == block.C && this.D == block.D;
        }

        public override int GetHashCode()
            => a * b * c * d * 8 / 5;
    }
}

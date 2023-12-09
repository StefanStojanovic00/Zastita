using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZastitaS
{
    public interface AlgoInterface
    {
         byte[] Encrypt(BitArray  input, int kljuc);
         byte[] Decrypt(BitArray  output, int kljuc);
    }
}

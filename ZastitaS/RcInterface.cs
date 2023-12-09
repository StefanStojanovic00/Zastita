using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZastitaS
{
    class RcInterface : AlgoInterface
    {
        private RailfenceCipher rc;
        public RcInterface(int kljuc)
        {
            rc = new RailfenceCipher(kljuc);
        }
        public byte[] Decrypt(BitArray output, int kljuc)
        {
            return rc.Dekripcija(output,kljuc);
        }

        public byte[] Encrypt(BitArray input,int kljuc)
        {
            return rc.Enkripcija(input,kljuc);
        }
    }
}

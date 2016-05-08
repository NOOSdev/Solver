using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollatzConjectureSolver
{
    // class BigUInt implements logic for huge natural numbers
    public class BigUInt
    {
        private ArrayList arrValue;
        private static ArrayList tmpValue = new ArrayList();
        private static int digit10;

        public BigUInt()
        {
            arrValue = new ArrayList();
            arrValue.Add((byte)0);

            digit10 = 10;
        }

        public byte[] Value
        {
            get
            {
                return (byte[])arrValue.ToArray(typeof(byte));
            }
            set
            {
                arrValue.Clear();

                if (value != null && value.Length > 0)
                {
                    arrValue.AddRange(value);
                }
                else
                {
                    arrValue.Add((byte)0);
                }
            }
        }

        // Check BigUINum is even or odd
        public bool isEvenNum()
        {
            byte res = (byte)arrValue[arrValue.Count - 1];
            return res % 2 == 0;
        }

        // If the sequence converged
        public bool isOne()
        {
            return (arrValue.Count == 1 && (byte)arrValue[0] == 1);
        }

        // Overloading for operator addition of Big unsigned number (BigUInt)
        public static BigUInt operator +(BigUInt a, byte b)
        {
            tmpValue.Clear();
            tmpValue.AddRange(a.Value);
            int index = tmpValue.Count - 1;
            byte carryOver = b;

            while (index >= 0)
            {
                byte tmp = (byte)tmpValue[index];
                tmp += carryOver;

                if (tmp >= digit10)
                {
                    carryOver = 1;
                    tmpValue[index] = (byte)(tmp - digit10);
                }
                else
                {
                    carryOver = 0;
                    tmpValue[index] = tmp;
                    index = 0;
                }

                index--;

                if (index < 0 && carryOver != 0) tmpValue.Insert(0, carryOver);
            }

            a.Value = (byte[])tmpValue.ToArray(typeof(byte));

            return a;
        }

        // Overloading for operator multiplication of Big unsigned number (BigUInt)
        public static BigUInt operator *(BigUInt a, byte b)
        {
            tmpValue.Clear();
            tmpValue.AddRange(a.Value);
            int index = tmpValue.Count - 1;
            byte carryOver = 0;

            while (index >= 0)
            {
                byte tmp = (byte)tmpValue[index];
                tmp = (byte)(tmp * b + carryOver);

                if (tmp >= digit10)
                {
                    carryOver = (byte)(tmp / digit10);
                    tmpValue[index] = (byte)(tmp - carryOver * digit10);
                }
                else
                {
                    tmpValue[index] = tmp;
                    carryOver = 0;
                }

                index--;

                if (index < 0 && carryOver != 0) tmpValue.Insert(0, carryOver);
            }

            a.Value = (byte[])tmpValue.ToArray(typeof(byte));

            return a;
        }

        // Overloading for operator division of Big unsigned number (BigUInt)
        public static BigUInt operator /(BigUInt a, byte b)
        {
            tmpValue.Clear();

            byte[] inValue = a.Value;
            int index = 0;
            byte carryOver = 0;
            bool needCheckZero = true;

            while (index < inValue.Length)
            {
                byte tmp = (byte)(carryOver * digit10 + (byte)inValue[index]);
                byte currDigit = (byte)(tmp / b);
                carryOver = (byte)(tmp - currDigit * b);

                if (currDigit == 0)
                {
                    if (!needCheckZero) tmpValue.Add(currDigit);
                }
                else
                {
                    needCheckZero = false;
                    tmpValue.Add(currDigit);
                }

                index++;
            }

            a.Value = (byte[])tmpValue.ToArray(typeof(byte));

            return a;
        }

        public static bool operator >(BigUInt a, BigUInt b)
        {
            byte[] arrA = a.Value;
            byte[] arrB = b.Value;

            if (arrA.Length != arrB.Length)
            {
                return arrA.Length > arrB.Length;
            }
            else
            {
                for (int index = 0; index < arrA.Length; index++)
                {
                    byte bA = (byte)arrA[index];
                    byte bB = (byte)arrB[index];

                    if (bA > bB) return true;
                    else if (bA < bB) return false;
                }
            }

            return false;
        }

        public static bool operator <(BigUInt a, BigUInt b)
        {
            byte[] arrA = a.Value;
            byte[] arrB = b.Value;

            if (arrA.Length != arrB.Length)
            {
                return arrA.Length < arrB.Length;
            }
            else
            {
                for (int index = 0; index < arrA.Length; index++)
                {
                    byte bA = (byte)arrA[index];
                    byte bB = (byte)arrB[index];

                    if (bA < bB) return true;
                    else if (bA > bB) return false;
                }
            }

            return false;
        }
    }

    // Main class for calculate
    public class SolverClass : IDisposable
    {
        private BigUInt _bigUInt, _maxUInt;
        private int _num3k;
        private int _num2k;
        private ArrayList _mainSequence;

        public SolverClass()
        {
            _bigUInt = new BigUInt();
            _maxUInt = new BigUInt();

            _num3k = _num2k = 0;

            _mainSequence = new ArrayList();
        }

        public void Dispose()
        {
            _mainSequence.Clear();
        }

        // Max member in mainSequence
        public BigUInt MaxUInt
        {
            get
            {
                return _maxUInt;
            }
        }

        // Number of 3k+1 operations
        public int Num3k
        {
            get
            {
                return _num3k;
            }
        }

        // Number of 2k operations
        public int Num2k
        {
            get
            {
                return _num2k;
            }
        }

        public ArrayList MainSequence
        {
            get
            {
                return _mainSequence;
            }
        }

        public string ByteArrToString(byte[] value)
        {
            StringBuilder res = new StringBuilder(value.Length);

            for (int index = 0; index < value.Length; index++) res.Append(value[index]);

            return res.ToString();
        }

        public byte[] StringToByteArr(string value)
        {
            string inputString = value.TrimStart('0');

            if (inputString == "") return null;

            byte[] inputNumber = new byte[inputString.Length];

            for (int i = 0; i < inputString.Length; i++) inputNumber[i] = (byte)(inputString[i] - '0');

            return inputNumber;
        }

        // Main function for calculate
        public void StartSolve(byte[] inputValue)
        {
            _num3k = _num2k = 0;
            _mainSequence.Clear();
            _bigUInt.Value = _maxUInt.Value = inputValue;

            _mainSequence.Add(this.ByteArrToString (_bigUInt.Value));

            while (!_bigUInt.isOne())
            {
                if (_bigUInt.isEvenNum())
                {
                    _bigUInt /= 2;
                    _num2k++;
                }
                else
                {
                    _bigUInt = _bigUInt * 3 + 1;
                    _num3k++;
                }

                _mainSequence.Add(this.ByteArrToString (_bigUInt.Value));

                if (_bigUInt > _maxUInt) _maxUInt.Value = _bigUInt.Value;
            }
        }
    }
}
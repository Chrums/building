using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fizz6.Building
{
    public class Chunk : MonoBehaviour
    {
        [Serializable]
        public class Cell
        {
            private int Detail = 0;
        }

        private static Dictionary<Vector3i, Chunk>[] World = new Dictionary<Vector3i, Chunk>[3];

        private Cell[,,] cells = null;

        private string Serialize()
        {
            return string.Empty;
        }

        private void Deserialize(string data)
        {
            if (int.TryParse(data, out int size))
            {
                cells = new Cell[size, size, size];
            }
        }
    }
}

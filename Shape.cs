using System;
using System.Collections.Generic;
using System.Linq;

namespace geometricshapes
{

    public enum Axises { X, Y, Z };
    public class Shape
    {
        public string Id { get; }
        public float Width { get; set; }
        public float Height { get; set; }
        public int SidesAmount { get; set; }
        /// <summary>
        /// Shape Position Array (x,y,z)
        /// </summary>
        /// <value></value>
        public int[] Position { get; } = new int[3];
        /// <summary>
        /// Shape Rotation Array (x,y,z)
        /// </summary>
        /// <value></value>
        public int[] Rotation { get; } = new int[3];
        public float Scale { get; set; }

        public Shape()
        {
            Id = Guid.NewGuid().ToString();
        }

        public void SetPositionForAxis(Axises axis, int value)
        {
            Position[(int)axis] = value;
        }
        public void SetRotationForAxis(Axises axis, int value)
        {
            Rotation[(int)axis] = value;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nWidth: {Width}\nHeight: {Height}\nSidesAmount: {SidesAmount}\nPosition: X:{Position[0]},Y:{Position[1]},Z:{Position[2]}\nRotation: X:{Rotation[0]},Y:{Rotation[1]},Z:{Rotation[2]}\nScale: {Scale}";
        }

    }


}
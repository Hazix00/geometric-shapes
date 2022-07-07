using System;
using System.Collections.Generic;
using System.Linq;

namespace geometricshapes
{
    public class ShapesStore
    {
        
        public Dictionary<string, Shape> Shapes { get; } = new Dictionary<string, Shape>();

        public ShapesStore() {}

        private void CheckShapeIdExists(string id)
        {
            if (Shapes.ContainsKey(id))
            {
                throw new Exception("Shape with this id already exists");
            }
        }
        private void CheckShapeIdNotExists(string id)
        {
            if (!Shapes.ContainsKey(id))
            {
                throw new Exception("Shape with this id does not exist");
            }
        }

        public Shape GetShape(string id)
        {
            CheckShapeIdNotExists(id);
            return Shapes[id];
        }

        public void AddShape(Shape shape)
        {
            CheckShapeIdExists(shape.Id);
            Shapes.Add(shape.Id, shape);
        }

        public void RemoveShape(string id)
        {
            CheckShapeIdNotExists(id);
            Shapes.Remove(id);
        }
    }
}
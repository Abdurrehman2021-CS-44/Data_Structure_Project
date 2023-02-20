using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarmentsSquare.BL
{
    public class Vertex
    {
        private List<Vertex> inNeighbours;
        private List<Vertex> outNeighbours;
        private string value;
        private int inTime;
        private int outTime;
        private string status;

        public int InTime { get => inTime; set => inTime = value; }
        public int OutTime { get => outTime; set => outTime = value; }
        public string Status { get => status; set => status = value; }

        public Vertex(string value)
        {
            this.inNeighbours = new List<Vertex>();
            this.outNeighbours = new List<Vertex>();
            this.value = value;
            this.InTime = 0;
            this.OutTime = 0;
            this.Status = "unvisited";
        }

        public bool hasInNeighbour(Vertex v)
        {
            if (inNeighbours.Contains(v))
            {
                return true;
            }
            return false;
        }
        public bool hasOutNeighbour(Vertex v)
        {
            if (outNeighbours.Contains(v))
            {
                return true;
            }
            return false;
        }
        public List<Vertex> getOutNeighbours()
        {
            return this.outNeighbours;
        }
        public List<Vertex> getInNeighbours()
        {
            return this.inNeighbours;
        }
        public void addInNeighbour(Vertex v)
        {
            this.inNeighbours.Add(v);
        }
        public void addOutNeighbour(Vertex v)
        {
            this.outNeighbours.Add(v);
        }
        public string getVlue()
        {
            return this.value;
        }

    }
}

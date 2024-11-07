using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Utils;

namespace Leetcode.Problems
{
    public class _841
    {
        HashSet<int> keysFound = new HashSet<int>();
        HashSet<int> visited = new HashSet<int>();
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            visited.Add(0);
            collectKeys(rooms[0]);

            while(keysFound.Count > 0)
            {
                var targetRoom = keysFound.First();
                if(!visited.Contains(targetRoom))
                {
                    collectKeys(rooms[targetRoom]);
                    visited.Add(targetRoom);
                }
                keysFound.Remove(targetRoom);
            }

            return visited.Count == rooms.Count;
        }

        private void collectKeys(IList<int> room)
        {
            foreach(var key in room)
            {
                if(!keysFound.Contains(key))
                {
                    keysFound.Add((int)key);
                }
            }
        }
    }
}

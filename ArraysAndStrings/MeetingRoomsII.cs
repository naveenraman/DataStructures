using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.ArraysAndStrings
{
    //Given an array of meeting time intervals consisting of start and end times [[s1,e1],[s2,e2],...] (si < ei), find the minimum number of conference rooms required.
    //Time Complexity: O(NlogN) because all we are doing is sorting the two arrays for start timings and end timings individually and each of them would contain N elements considering there are N intervals.
    //Space Complexity: O(N) because we create two separate arrays of size N, one for recording the start times and one for the end times.
    public class MeetingRoomsII
    {
        public int MinMeetingRooms(int[][] intervals)
        {
            int size = intervals.Length;
            if (size == 0)
                return 0;
            int[] start = new int[size];
            int[] end = new int[size];
            for (int i = 0; i < size; i++)
            {
                start[i] = intervals[i][0];
                end[i] = intervals[i][1];
            }
            Array.Sort(start);
            Array.Sort(end);
            int rooms = 0;
            int endPtr = 0;
            for (int i = 0; i < start.Length; i++)
            {
                if (start[i] < end[endPtr])
                    rooms++;
                else
                    endPtr++;
            }
            return rooms;
        }
    }
}

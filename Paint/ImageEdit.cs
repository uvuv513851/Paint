using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace sheet_painter {
    internal static class ImageEdit {
        
        static public Image proceedImage(Image initial, int x, int y, Color c) {
            Bitmap image = new Bitmap(initial);
            Color initialColor = image.GetPixel(x, y);
            HashSet<KeyValuePair<int, int>> used = new HashSet<KeyValuePair<int, int>>();
            Queue<KeyValuePair<int, int>> list = new Queue<KeyValuePair<int, int>>();
            list.Enqueue(new KeyValuePair<int, int>(x, y));
            KeyValuePair<int, int> current;
            List<KeyValuePair<int, int>> store = new List<KeyValuePair<int, int>>();
            while (list.Count > 0) {
               
                current = list.Dequeue();
                store.Add(current);
                if (used.Contains(current)) continue;
                used.Add(current);
                
                
                try {
                    int color = image.GetPixel(current.Key, current.Value).ToArgb();
                    if (color == initialColor.ToArgb()) {
                        KeyValuePair<int, int> left = new KeyValuePair<int, int>(current.Key - 1, current.Value);
                        KeyValuePair<int, int> right = new KeyValuePair<int, int>(current.Key + 1, current.Value);
                        KeyValuePair<int, int> top = new KeyValuePair<int, int>(current.Key, current.Value + 1);
                        KeyValuePair<int, int> bottom = new KeyValuePair<int, int>(current.Key, current.Value - 1);
                        list.Enqueue(left);
                        list.Enqueue(right);
                        list.Enqueue(top);
                        list.Enqueue(bottom);
                        
                        image.SetPixel(current.Key, current.Value, c);
                        
                    } 
                } catch (Exception e) {
                    
                }
            }
            return image;
        }

    }
}

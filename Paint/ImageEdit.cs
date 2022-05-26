using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace sheet_painter {
    internal static class ImageEdit {
        
        static public Image cancel(Image initial, int x, int y) {
            return ImageEdit.proceedImage(initial, x, y, Color.White, true);
        }
        static public Image proceedImage(Image initial, int x, int y, Color c, bool isCancel) {
            Bitmap image = new Bitmap(initial);
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
                    if (Math.Abs(color - Color.Black.ToArgb()) > 1000000) {
                        image.SetPixel(current.Key, current.Value, c);
                        for (int i = -1; i < 2; i++) {
                            for (int j = -1; j < 2; j++) {
                                if (i != 0 || j != 0) {
                                    if (current.Key + i < 0 || current.Key + i >= image.Width) continue;
                                    if (current.Value + j < 0 || current.Value + j >= image.Height) continue;
                                    KeyValuePair<int, int> element = new KeyValuePair<int, int>(current.Key + i, current.Value + j);
                                    list.Enqueue(element);
                                }
                            }
                        }
                    } 
                } catch (Exception e) {
                    MessageBox.Show(current.ToString());
                }
            }
            return image;
        }

    }
}

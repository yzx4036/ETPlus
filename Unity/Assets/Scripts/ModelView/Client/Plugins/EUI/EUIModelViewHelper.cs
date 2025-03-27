using System.Collections.Generic;

namespace ET.Client
{
    public static class EUIModelViewHelper
    {
        public static void AddUIScrollItems<K, T>(this K self, ref Dictionary<int, EntityRef<T>> dictionary, int count) where K : Entity, IUILogic
                where T : Entity, IAwake, IUIScrollItem
        {
            if (dictionary == null)
            {
                dictionary = new Dictionary<int, EntityRef<T>>();
            }

            if (count <= 0)
            {
                return;
            }

            foreach (var item in dictionary)
            {
                ((T)item.Value)?.Dispose();
            }

            dictionary.Clear();
            for (int i = 0; i <= count; i++)
            {
                T itemServer = self.AddChild<T>(true);
                dictionary.Add(i, itemServer);
            }
        }
    }
}
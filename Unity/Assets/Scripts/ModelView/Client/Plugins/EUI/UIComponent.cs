﻿using System.Collections.Generic;

namespace ET.Client
{
    public interface IUILogic
    {
        
    }

    public interface IUIScrollItem
    {
        
    }
    

    [ComponentOf()]
    public class UIComponent : Entity,IAwake,IDestroy
    {
        public Dictionary<int, EntityRef<UIBaseWindow>> AllWindowsDic     = new Dictionary<int, EntityRef<UIBaseWindow>>();
        public List<WindowID> UIBaseWindowlistCached           = new List<WindowID>();
        public Dictionary<int, EntityRef<UIBaseWindow>> VisibleWindowsDic = new Dictionary<int, EntityRef<UIBaseWindow>>();
        public Queue<WindowID> StackWindowsQueue               = new Queue<WindowID>();
        public bool IsPopStackWndStatus                        = false;

    }
}
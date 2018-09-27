local UIPageAndGrid = require("UI/Chat/UIPageAndGrid")
local UIPageAndGrid_Widget = require("UI/Chat/UIPageAndGrid_Widget")
local UIPageAndGrid_Item = require("UI/Chat/UIPageAndGrid_Item")

-----------------------------SysEmojiItem-----------------------------
local SysEmojiItem = class("SysEmojiItem", UIPageAndGrid_Item)
function SysEmojiItem:ctor(trs, funcOnClick)
    UIPageAndGrid_Item.ctor(self, trs, funcOnClick)

    --组件
    self._sp = trs:Find("icon"):GetComponent("UISprite")

    --变量

    self:Init()
end

function SysEmojiItem:Show(data)
    UIPageAndGrid_Item.Show(self, data)

    self._sp.spriteName = self._data.icon
    self._sp:MakePixelPerfect()
end
-----------------------------SysEmojiItem-----------------------------


-----------------------------SysEmojiWidget-----------------------------
local SysEmojiWidget = class("SysEmojiWidget", UIPageAndGrid_Widget)
function SysEmojiWidget:ctor(trs, ui)
    UIPageAndGrid_Widget.ctor(self, trs, ui)

    --组件
    self._svTrs = trs:Find("scrollview")
    
    --变量
    self._dataDic = ChatMgr.GetSysEmojiPageDic()
    self._numPerPage = ChatMgr.GetSysEmojiNumPerPage()

    self._pageAndGrid = UIPageAndGrid.new(self._svTrs, self._ui, SysEmojiItem, 
                            self._numPerPage, self._funcOnItemClick)

    --
    self:Hide()
end

--表情点击回调
function SysEmojiWidget:OnItemClick(id)
    if not id then
        return
    end

    --基类的方法只做UI表现
    UIPageAndGrid_Widget.OnItemClick(self, id)

    --在具体的类里做点击后的业务逻辑处理
    --发送表情
    GameLog.LogError("---------------------------------------------------表情, id = %s", id)
end

function SysEmojiWidget:Show()
    UIPageAndGrid_Widget.Show(self)

    self._pageAndGrid:Show(self._dataDic)
end

return SysEmojiWidget
-----------------------------SysEmojiWidget-----------------------------

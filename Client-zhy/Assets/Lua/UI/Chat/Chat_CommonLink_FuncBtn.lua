local UIPageAndGrid = require("UI/Chat/UIPageAndGrid")
local UIPageAndGrid_Widget = require("UI/Chat/UIPageAndGrid_Widget")
local UIPageAndGrid_Item = require("UI/Chat/UIPageAndGrid_Item")

-----------------------------FuncBtnItem-----------------------------
local FuncBtnItem = class("FuncBtnItem", UIPageAndGrid_Item)
function FuncBtnItem:ctor(trs, funcOnClick)
    UIPageAndGrid_Item.ctor(self, trs, funcOnClick)

    --组件
    self._norSp = trs:Find("nor"):GetComponent("UISprite")
    self._specSp = trs:Find("spec"):GetComponent("UISprite")
    self._name = trs:Find("name"):GetComponent("UILabel")

    --变量

    self:Init()
end

function FuncBtnItem:Show(data)
    UIPageAndGrid_Item.Show(self, data)

    self._name.text = self._data.name
    self._norSp.spriteName = self._data.norSpName
    self._specSp.spriteName = self._data.specSpName
end
-----------------------------FuncBtnItem-----------------------------

-----------------------------FuncBtnWidget-----------------------------
local FuncBtnWidget = class("FuncBtnWidget", UIPageAndGrid_Widget)
function FuncBtnWidget:ctor(trs, ui)
    UIPageAndGrid_Widget.ctor(self, trs, ui)

    --组件
    self._svTrs = trs:Find("scrollview")

    --变量
    --根据打开途径不同，功能按钮列表不同，读程序内配置文件
    self._dataDic = {}
    self._numPerPage = 9

    self._pageAndGrid = UIPageAndGrid.new(self._svTrs, self._ui, FuncBtnItem, 
                            self._numPerPage, self._funcOnItemClick)

    --
    --所有的widget，由CommonLink界面往里注册
    self._funcId2Widget = {}
    self._curFuncId = -1
    --
    self:Hide()    
end

function FuncBtnWidget:ShowWidget(funcId)
    if funcId and self._funcId2Widget[funcId] then
        self._funcId2Widget[funcId]:Show()
    end
end

function FuncBtnWidget:HideWidget(funcId)
    if funcId and self._funcId2Widget[funcId] then
        self._funcId2Widget[funcId]:Hide()
    end
end

function FuncBtnWidget:AddWidget(funcId, widget)
    self._funcId2Widget[funcId] = widget
end

--功能按钮点击回调
function FuncBtnWidget:OnItemClick(id)
    if not id then
        return
    end
    if self._curFuncId == id then
        return
    end

    --基类的方法只做UI表现
    UIPageAndGrid_Widget.OnItemClick(self, id)

    --切换右侧界面
    self:HideWidget(self._curFuncId)
    self._curFuncId = id
    self:ShowWidget(self._curFuncId)

    --记录功能按钮
    ChatMgr.SetLastFuncId(self._curFuncId)
end

function FuncBtnWidget:Show(dataDic)
    UIPageAndGrid_Widget.Show(self)

    self._dataDic = dataDic

    self._pageAndGrid:Show(self._dataDic)

    --处理上次打开的功能按钮id
    local lastFuncId = ChatMgr.GetLastFuncId()
    self:OnItemClick(lastFuncId)
end

function FuncBtnWidget:Hide()
    UIPageAndGrid_Widget.Hide(self)

    self:HideWidget(self._curFuncId)
    self._curFuncId = -1
end
return FuncBtnWidget
-----------------------------FuncBtnWidget-----------------------------

------------------------------------TwoItem------------------------------------
local TwoItem = class("TwoItem")
function TwoItem:ctor(trs, funcOnClick)
    --组件
    self._transform = trs
    self._gameObject = trs.gameObject
    self._norGo = trs:Find("nor").gameObject
    self._specGo = trs:Find("spec").gameObject
    self._norLbl = trs:Find("nor/label"):GetComponent("UILabel")
    self._specLbl = trs:Find("spec/label"):GetComponent("UILabel")
    self._specLbl.text = ""
    self._norLbl.text = ""
    self._lis = UIEventListener.Get(self._gameObject)
    self._lis.onClick = UIEventListener.VoidDelegate(self.OnClick, self)

    --变量
    self._defaultData = { id = -1, content = "" }
    self._data = self._defaultData
    self._isShowed = false
    self._funcOnClick = funcOnClick
    self._zero = Vector3.zero
    self._one = Vector3.one

    self:ToNor()
    self:Hide()
end

function TwoItem:SetVisible(visible)
    self._gameObject:SetActive(visible)
    self._isShowed = visible
end

function TwoItem:IsShowed()
    return self._isShowed
end

--[[
data = { 
    id = 1, content = content
 }
--]]
function TwoItem:Show(data)
    self:SetVisible(true)

    self._data = data
    self._norLbl.text = self._data.content
    self._specLbl.text = self._data.content
end

function TwoItem:Hide()
    self:SetVisible(false)

    self._data = self._defaultData
    self._norLbl.text = ""
    self._specLbl.text = ""

    self:ToNor()
end

function TwoItem:ToNor()
    self._specGo:SetActive(false)
    self._norGo:SetActive(true)
end

function TwoItem:ToSpec()
    self._norGo:SetActive(false)
    self._specGo:SetActive(true)
end

function TwoItem:OnClick(eventData)
    if self._funcOnClick then
        self._funcOnClick(self._data.id)
    end
end

function TwoItem:SetParent(parent)
    self._transform.parent = parent
    self._transform.localPosition = self._zero
    self._transform.localScale = self._one
end

function TwoItem:GetTransform()
    return self._transform
end

function TwoItem:GetId()
    return self._data.id
end
------------------------------------TwoItem------------------------------------

------------------------------------oneitem------------------------------------
local OneItem = class("OneItem")
function OneItem:ctor(trs, funcOnClick, funcGetTwoItem)
    --组件
    self._transform = trs
    self._gameObject = trs.gameObject
    self._widget = trs:GetComponent("UIWidget")
    self._norGo = trs:Find("nor").gameObject
    self._specGo = trs:Find("spec").gameObject
    self._norLbl = trs:Find("nor/label"):GetComponent("UILabel")
    self._specLbl = trs:Find("spec/label"):GetComponent("UILabel")
    self._specLbl.text = ""
    self._norLbl.text = ""
    self._bg = trs:Find("bg"):GetComponent("UISprite")
    self._bgGo = self._bg.gameObject
    self._girdTrs = trs:Find("grid")
    self._gridGo = self._girdTrs.gameObject
    self._grid = self._girdTrs:GetComponent("UIGrid")
    self._lis = UIEventListener.Get(self._gameObject)
    self._lis.onClick = UIEventListener.VoidDelegate(self.OnClick, self)

    --变量
    self._defaultData = { id = -1, content = "", list = {} }
    self._data = self._defaultData
    self._isShowed = false
    self._widgetH = self._widget.height
    self._funcOnClick = funcOnClick
    self._funcGetTwoItem = funcGetTwoItem
    self._lastTwoItem = nil
    self._expanded = false  --是否处于展开状态

    self:ToNor()
    self:Hide()
end

function OneItem:SetVisible(visible)
    self._gameObject:SetActive(visible)
    self._isShowed = visible
end

function OneItem:IsShowed()
    return self._isShowed
end

--[[
data = { 
    id = 1, content = "1", list = { 
        { id = 1, content = "1" },
        { id = 2, content = "2" },
        { id = 3, content = "3" },
     }
 }
--]]
function OneItem:Show(data)
    self:SetVisible(true)
    self._data = data
    self._norLbl.text = self._data.content
    self._specLbl.text = self._data.content
end

function OneItem:Hide()
    self:SetVisible(false)
    self._data = self._defaultData
    self._norLbl.text = ""
    self._specLbl.text = ""

    self:ToNor()
end

function OneItem:SetExpanded(expanded)
    self._expanded = expanded
end

function OneItem:GetExpanded()
    return self._expanded
end

function OneItem:ToNor()
    self._specGo:SetActive(false)
    self._norGo:SetActive(true)

    --处理bg和widget
    self._bgGo:SetActive(false)
    self._gridGo:SetActive(false)
    self._widget.bottomAnchor.target = nil
    self._widget:ResetAndUpdateAnchors()
    self._widget.height = self._widgetH
    self._widget:Update()

    self:SetExpanded(false)
end

function OneItem:GetTwoItem()
    if self._funcGetTwoItem then
        return self._funcGetTwoItem()
    end
end

function OneItem:InitGrid()
    self._gridGo:SetActive(true)
    for _, twoData in ipairs(self._data.list) do
        if twoData then
            local twoItem = self:GetTwoItem()
            if twoItem then
                twoItem:SetParent(self._girdTrs)
                twoItem:Show(twoData)
                self._lastTwoItem = twoItem
            end
        end
    end
    self._grid:Reposition()
end

function OneItem:InitBg()
    if not self._lastTwoItem then
        self._bgGo:SetActive(false)
        return
    end
    self._bgGo:SetActive(true)
    local h1 = self._bg.height
    self._bg.bottomAnchor.target = self._lastTwoItem:GetTransform()
    self._bg.bottomAnchor.relative = 0
    self._bg.bottomAnchor.absolute = -4
    self._bg:ResetAndUpdateAnchors()
    self._bg:Update()
end

function OneItem:InitWidget()
    if not self._lastTwoItem then
        self._widget.height = self._widgetH
        return
    end
    local h1 = self._widget.height
    self._widget.bottomAnchor.target = self._lastTwoItem:GetTransform()
    self._widget.bottomAnchor.relative = 0
    self._widget.bottomAnchor.absolute = -5
    self._widget:ResetAndUpdateAnchors()
end

function OneItem:ToSpec()
    self._norGo:SetActive(false)
    self._specGo:SetActive(true)

    --组装grid
    self:InitGrid()
    --设置bg的锚点
    self:InitBg()
    --设置widget的锚点
    self:InitWidget()

    self:SetExpanded(true)
end

function OneItem:OnClick(eventData)
    if self._funcOnClick then
        self._funcOnClick(self._data.id)
    end
end

function OneItem:GetId()
    return self._data.id
end
------------------------------------oneitem------------------------------------

------------------------------------UITableAndGrid------------------------------------
local UITableAndGrid = class("UITableAndGrid")
function UITableAndGrid:ctor(trs)
    --组件
    self._transform = trs
    self._gameObject = trs.gameObject
    self._tableTrs = trs:Find("table")
    self._table = self._tableTrs:GetComponent("UITable")
    self._table.onCustomSort = System.Comparison_UnityEngine_Transform(self.CustomTableSort, self)
    self._gridCustomSort = System.Comparison_UnityEngine_Transform(self.CustomGridSort, self)

    --变量
    self._data = {}
    self._ui = nil
    self._oneItemTemp = nil
    self._twoItemTemp = nil
    self._funcOnOneItemClick = nil
    self._funcOnTwoItemClick = nil
    self._oneItemList = {}
    self._twoItemList = {}
    self._curOneId = -1
    self._curTwoId = -1
    self._isShowed = false

    self:Hide()
end

function UITableAndGrid:SetVisible(visible)
    self._gameObject:SetActive(visible)
    self._isShowed = visible
end

function UITableAndGrid:IsShowed()
    return self._isShowed
end

function UITableAndGrid:CustomSort(left, right)
    local leftName = left.name
    local rightName = right.name
    local leftNum = tonumber(string.sub(leftName, 8))
    local rightNum = tonumber(string.sub(rightName, 8))
    if leftNum < rightNum then
        return -1
    elseif leftNum > rightNum then
        return 1
    else
        return 0
    end
end

function UITableAndGrid:CustomGridSort(left, right)
    return self:CustomSort(left, right)
end

function UITableAndGrid:CustomTableSort(left, right)
    return self:CustomSort(left, right)
end

--该方法在UI.OnCreate方法里调用
function UITableAndGrid:Init(ui, oneItemTemp, twoItemTemp, funcOnOneItemClick, funcOnTwoItemClick)
    self._ui = ui
    self._oneItemTemp = oneItemTemp
    self._twoItemTemp = twoItemTemp
    self._funcOnOneItemClick = funcOnOneItemClick
    self._funcOnTwoItemClick = funcOnTwoItemClick

    self:CacheOneItemList()
    self:CacheTwoItemList()
end

--[[
data = { 
    { id = 1, content = "1", list = { 
        { id = 1, content = "1" },
        { id = 2, content = "2" },
        { id = 3, content = "3" },
     } },
     { id = 2, content = "2", list = { 
        { id = 1, content = "1" },
        { id = 2, content = "2" },
        { id = 3, content = "3" },
     } },
 }
--]]
--该方法在UI.OnEnable方法里调用
function UITableAndGrid:Show(data)
    self:SetVisible(true)
    self._data = data

    for _, oneData in ipairs(self._data) do
        if oneData then
            local oneItem = self:GetOneItem()
            oneItem:Show(oneData)
        end
    end

    self:Reposition()
end

function UITableAndGrid:Hide()
    self:SetVisible(false)
    self:TakeTwoItem()
    self:TakeOneItem()
    self._curOneId = -1
    self._curTwoId = -1
end

--手动定义一二级列表按钮的点击状态
--不为-1则选中
--不抛出点击事件
function UITableAndGrid:CustomShowOneTwoExpanded(oneId, twoId)
    if oneId ~= -1 then
        self:OnOneItemClick(oneId, false)

        if twoId ~= -1 then
            self:OnTwoItemClick(twoId, false)
        end
    end
end

function UITableAndGrid:CheckOneDataRange(id)
    for _, oneData in ipairs(self._data) do
        if oneData and oneData.id == id then
            return true
        end
    end
    return false
end

function UITableAndGrid:GetTwoDataList(oneId)
    local oneData = self:GetOneDataById(oneId)
    if oneData then
        return oneData.list
    end
    return {}
end

function UITableAndGrid:CheckTwoDataRange(id)
    local twoDataList = self:GetTwoDataList(self._curOneId)
    if not twoDataList then
        return false
    end
    for _, twoData in ipairs(twoDataList) do
        if twoData and twoData.id == id then
            return true
        end
    end
    return false
end

function UITableAndGrid:GetOneDataById(id)
    for _, oneData in ipairs(self._data) do
        if oneData and oneData.id == id then
            return oneData
        end
    end
    return nil
end

function UITableAndGrid:GetOneItemById(id)
    for _, oneItem in ipairs(self._oneItemList) do
        if oneItem and oneItem:GetId() == id then
            return oneItem
        end
    end
    return nil
end

function UITableAndGrid:NorOneItem(id)
    if not self:CheckOneDataRange(id) then
        return
    end
    local oneItem = self:GetOneItemById(id)
    if not oneItem then
        return
    end
    oneItem:ToNor()

    --回收twoitem
    self:TakeTwoItem()

    --重置twoid
    self._curTwoId = -1
end

function UITableAndGrid:SpecOneItem(id)
    if not self:CheckOneDataRange(id) then
        return
    end
    local oneItem = self:GetOneItemById(id)
    if not oneItem then
        return
    end
    oneItem:ToSpec()
end

function UITableAndGrid:GetTwoItemById(id)
    for _, twoItem in ipairs(self._twoItemList) do
        if twoItem and twoItem:GetId() == id then
            return twoItem
        end
    end
    return nil
end

function UITableAndGrid:NorTwoItem(id)
    if not self:CheckTwoDataRange(id) then
        return
    end
    local twoitem = self:GetTwoItemById(id)
    if not twoitem then
        return
    end
    twoitem:ToNor()
end

function UITableAndGrid:SpecTwoItem(id)
    if not self:CheckTwoDataRange(id) then
        return
    end
    local twoItem = self:GetTwoItemById(id)
    if not twoItem then
        return
    end
    twoItem:ToSpec()
end

--将所有的twoitem回收
function UITableAndGrid:TakeTwoItem()
    for _, twoItem in ipairs(self._twoItemList) do
        if twoItem and twoItem:IsShowed() then
            twoItem:SetParent(self._transform)
            twoItem:Hide()
        end
    end
end

--回收所有的oneitem
function UITableAndGrid:TakeOneItem()
    for _, oneItem in ipairs(self._oneItemList) do
        if oneItem and oneItem:IsShowed() then
            oneItem:Hide()
        end
    end
end

function UITableAndGrid:Reposition()
    self._table:Reposition()
end

--oneitem点击回调
--throwEvent：是否抛出点击事件
function UITableAndGrid:OnOneItemClick(id, throwEvent)
    if not self:CheckOneDataRange(id) then
        return
    end
    if self._curOneId == id then
        local oneItem = self:GetOneItemById(id)
        if oneItem then
            if oneItem:GetExpanded() then
                self:NorOneItem(self._curOneId)
            else
                self:SpecOneItem(self._curOneId)        
            end
        end
    else
        self:NorOneItem(self._curOneId)
        self._curOneId = id
        self:SpecOneItem(self._curOneId)
    end

    self:Reposition()

    if throwEvent then
        if self._funcOnOneItemClick then
            local oneItem = self:GetOneItemById(self._curOneId)
            if oneItem then
                self._funcOnOneItemClick(self._curOneId, oneItem:GetExpanded())
            end
        end
    end
end

--twoitem点击回调
--throwEvent：是否抛出点击事件
function UITableAndGrid:OnTwoItemClick(id, throwEvent)
    if not self:CheckTwoDataRange(id) then
        return
    end
    if self._curTwoId == id then
        return
    end
    self:NorTwoItem(self._curTwoId)
    self._curTwoId = id
    self:SpecTwoItem(self._curTwoId)

    if throwEvent then
        if self._funcOnTwoItemClick then
            self._funcOnTwoItemClick(self._curTwoId)
        end
    end
end

function UITableAndGrid:GetCurOneId()
    return self._curOneId
end

function UITableAndGrid:GetCurTwoId()
    return self._curTwoId
end

--初始化固定数量的oneitem备用
function UITableAndGrid:CacheOneItemList()
    --数字10没有逻辑意义
    for idx = 1, 10 do
        self:CreateOneItem()
    end
end

function UITableAndGrid:CreateOneItem()
    local trs = self._ui:DuplicateAndAdd(self._oneItemTemp, self._tableTrs, 0)
    trs.name = "oneitem" .. tostring(#self._oneItemList + 1)
    --待实现
    --将这些local方法都做成成员变量
    local funcOnClick = function(id)
        self:OnOneItemClick(id, true)
    end
    local funcGetTwoItem = function()
        return self:GetTwoItem()
    end
    self._oneItemList[#self._oneItemList + 1] = OneItem.new(trs, funcOnClick, funcGetTwoItem)
    return self._oneItemList[#self._oneItemList]
end

function UITableAndGrid:GetUnShowedOneItem()
    for _, oneItem in ipairs(self._oneItemList) do
        if oneItem and not oneItem:IsShowed() then
            return oneItem
        end
    end
    return nil
end

function UITableAndGrid:GetOneItem()
    local oneItem = self:GetUnShowedOneItem()
    if oneItem then
        return oneItem
    else
        return self:CreateOneItem()
    end
end

--初始化固定数量twoitem备用
function UITableAndGrid:CacheTwoItemList()
    --数字10没有逻辑意义
    for idx = 1, 10 do
        self:CreateTwoItem()
    end
end

function UITableAndGrid:CreateTwoItem()
    local trs = self._ui:DuplicateAndAdd(self._twoItemTemp, self._transform, 0)
    trs.name = "twoitem" .. tostring(#self._twoItemList + 1)
    local func = function(id)
        self:OnTwoItemClick(id, true)
    end
    self._twoItemList[#self._twoItemList + 1] = TwoItem.new(trs, func)
    return self._twoItemList[#self._twoItemList]
end

function UITableAndGrid:GetUnShowedTwoItem()
    for _, twoItem in ipairs(self._twoItemList) do
        if twoItem and not twoItem:IsShowed() then
            return twoItem
        end
    end
    return nil
end

function UITableAndGrid:GetTwoItem()
    local twoItem = self:GetUnShowedTwoItem()
    if twoItem then
        return twoItem
    else
        return self:CreateTwoItem()
    end
end

return UITableAndGrid
------------------------------------UITableAndGrid------------------------------------

function clone(object)--clone函数  
	local lookup_table = {}--新建table用于记录  
	local function _copy(object)--_copy(object)函数用于实现复制  
		if type(object) ~= "table" then
			return object   ---如果内容不是table 直接返回object(例如如果是数字\字符串直接返回该数字\该字符串)  
		elseif lookup_table[object] then
			return lookup_table[object]--这里是用于递归滴时候的,如果这个table已经复制过了,就直接返回  
		end
		local new_table = {}
		lookup_table[object] = new_table--新建new_table记录需要复制的二级子表,并放到lookup_table[object]中.  
		for key, value in pairs(object) do
			new_table[_copy(key)] = _copy(value)--遍历object和递归_copy(value)把每一个表中的数据都复制出来  
		end
		return setmetatable(new_table, getmetatable(object))--每一次完成遍历后,就对指定table设置metatable键值  
	end
	return _copy(object)--返回clone出来的object表指针/地址  
end

function class(classname, super)
	local superType = type(super)
	local cls
	
	--如果父类既不是函数也不是table则说明父类为空  
	if superType ~= "function" and superType ~= "table" then
		superType = nil
		super = nil
	end
	
	--如果父类的类型是函数或者是C对象  
	if superType == "function" or(super and super.__ctype == 1) then
		-- inherited from native C++ Object  
		cls = {}
		
		--如果父类是表则复制成员并且设置这个类的继承信息  
		--如果是函数类型则设置构造方法并且设置ctor函数  
		if superType == "table" then
			-- copy fields from super  
			for k, v in pairs(super) do cls[k] = v end
			cls.__create = super.__create
			cls.super	= super
		else
			cls.__create = super
			cls.ctor = function() end
		end
		
		--设置类型的名称  
		cls.__cname = classname
		cls.__ctype = 1
		
		--定义该类型的创建实例的函数为基类的构造函数后复制到子类实例  
		--并且调用子数的ctor方法  
		function cls.new(...)
			local instance = cls.__create(...)
			-- copy fields from class to native object  
			for k, v in ipairs(cls) do instance[k] = v end
			instance.class = cls
			instance:ctor(...)
			return instance
		end
		
	else
		--如果是继承自普通的lua表,则设置一下原型，并且构造实例后也会调用ctor方法  
		-- inherited from Lua Object  
		if super then
			cls = {}
			setmetatable(cls, {__index = super})
			cls.super = super
		else
			cls = {ctor = function() end}
		end
		
		cls.__cname = classname
		cls.__ctype = 2 -- lua  
		cls.__index = cls
		
		function cls.new(...)
			local instance = setmetatable({}, cls)
			instance.class = cls
			instance:ctor(...)
			return instance
		end
	end
	
	return cls
end

#! python2
#coding:utf-8

import traceback
import os
import sys

def export_proto():
	proto_path = os.path.abspath(sys.path[0] + "/../Proto")
	lua_path = os.path.abspath(sys.path[0] + "/../Client-zhy/Assets/Lua/Logic/Proto")
	lua_tmp_path = os.path.abspath(sys.path[0] + "/protobuf/luascript")
	#py_path = os.path.abspath(sys.path[0] + u"/../../../../../res/DesignResource/数据表格/ProtoGen/export").encode("gbk")
	protos = []
	for file in os.listdir(proto_path):      
		abspath = proto_path + "/" + file
		if(not os.path.isdir(abspath)):  
			if(file[-3:] == "oto"):
				protos.append(abspath)
				protos.append(" ")
	proto_join = ''.join(protos)
	#python_cmd = "protoc --proto_path=" + proto_path + " --python_out=" + py_path + " " + proto_join
	lua_cmd = "protoc --proto_path=" + proto_path + " --lua_out=" + lua_tmp_path + " " + proto_join
	print u"清理旧文件..."
	#os.system("rm -f " + py_path + "/*.py")
	#os.system("rm -f " + py_path + "/*.pyc")
	os.system("rm -f " + lua_path + "/*.lua")
	#os.system("rm -rf ./*.lua")

	print u"导出新文件..."
	#os.system(python_cmd.replace("\\","/")) 
	os.system(lua_cmd.replace("\\","/"))      

	print u"处理LUA脚本..."       
	os.chdir(lua_tmp_path)
	os.system("protoc-gen-lua-tools")
	os.system("mv " + lua_tmp_path + "/newlua/*.lua " + lua_path)    
	os.system("rm -rf ./*.lua")

	print u"生成LUA require文件..."
	outPath = os.path.abspath(lua_path + "/AllPB.lua")
	fileObj = open(outPath,"wb")
	fileObj.write("--this file is generated by tools, do not edit\n\n")
	fileObj.write("module(..., package.seeall)\n")
	fileObj.write("function Init()\n")
	for file in os.listdir(lua_path):      
		if file[-3:] == "lua" and file != "AllPB.lua":
			fileObj.write("\trequire(\"Logic/Proto/"+ file[:-4] +"\")\n")		
	fileObj.write("end\n")
	fileObj.close()

if(__name__ == "__main__"):
	try:        
		export_proto()
		print("build finish")
	except:
		print("build failed")
		traceback.print_exc()
		raw_input()

-- Generated By protoc-gen-lua Do not Edit

local Chat_pbTable = {}


local protobuf = require "protobuf/protobuf"
module('Chat_pb',package.seeall)


Chat_pbTable.CHATROOMTYPE = protobuf.EnumDescriptor();
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_NONE_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_WORLD_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_TEAM_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_GANG_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_PROFESSION_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_SCENE_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_NEW_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_CITY_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_SYSTEM_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_BULLET_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_GROUP_TEMP_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_GROUP_FRIEND_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_NOTICE_SINGLE_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_NOTICE_GLOBAL_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATMSGTYPE = protobuf.EnumDescriptor();
Chat_pbTable.CHATMSGTYPE_CHATMSG_BULLET_ADD_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATMSGTYPE_CHATMSG_BULLET_THUMBUP_TRANSMIT_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATMSGTYPE_CHATMSG_BULLET_COMMENT_TRANSMIT_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATMSGTYPE_CHATMSG_COMMON_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATMSGTYPE_CHATMSG_FRIEND_PRIVATE_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATMSGTYPE_CHATMSG_TEAM_PRIVATE_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATMSGTYPE_CHATMSG_FRIEND_QUN_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATMSGTYPE_CHATMSG_PAINT_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATMSGSENDER = protobuf.Descriptor();
Chat_pbTable.CHATMSGSENDER_SENDERID_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.CHATMSGSENDER_SENDERLEVEL_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.CHATMSGSENDER_SENDERNAME_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.CHATMSGSENDER_SENDERDETAIL_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.MSGLINKDESCEMOJI = protobuf.Descriptor();
Chat_pbTable.MSGLINKDESCEMOJI_NAME_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.MSGLINKDESCTEXT = protobuf.Descriptor();
Chat_pbTable.MSGLINKDESCTEXT_COLOR_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.MSGLINKDESCTEXTURE = protobuf.Descriptor();
Chat_pbTable.MSGLINKDESCTEXTURE_NAME_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.MSGLINKDESC = protobuf.Descriptor();
Chat_pbTable.MSGLINKDESC_EMOJIDESC_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.MSGLINKDESC_TEXTDESC_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.MSGLINKDESC_TEXTUREDESC_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.CHATMSGLINK = protobuf.Descriptor();
Chat_pbTable.CHATMSGLINK_LINKTYPE = protobuf.EnumDescriptor();
Chat_pbTable.CHATMSGLINK_LINKTYPE_AT_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATMSGLINK_LINKTYPE_PLAYER_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATMSGLINK_LINKTYPE_PAINT_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATMSGLINK_LINKTYPE_EMOJI_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATMSGLINK_LINKTYPE_EMOJI_CUSTOM_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATMSGLINK_LINKTYPE_ITEM_ENUM = protobuf.EnumValueDescriptor();
Chat_pbTable.CHATMSGLINK_LINKTYPE_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.CHATMSGLINK_INTPARAMS_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.CHATMSGLINK_STRPARAMS_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.CHATMSGLINK_BYTEPARAMS_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.CHATMSGLINK_CONTENT_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.CHATMSGLINK_ISVALID_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.CHATMSGLINK_LINKDESC_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.CHATMSGLINK_STATICID_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.CHATMSGLINK_DYNAMICID_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.CHATMSGLINK_CONTENTAUTOID_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.CHATMSGLINK_CONTENTWITHID_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.CHATMSGCOMMON = protobuf.Descriptor();
Chat_pbTable.CHATMSGCOMMON_SENDER_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.CHATMSGCOMMON_ROOMTYPE_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.CHATMSGCOMMON_LINKS_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.CHATMSGCOMMON_CONTENT_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.CHATMSGCOMMON_CONTENTPREFIX_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.CHATMSGCOMMON_CONTENTPOSTFIX_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.CHATMSG = protobuf.Descriptor();
Chat_pbTable.CHATMSG_MSGID_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.CHATMSG_MSGTYPE_FIELD = protobuf.FieldDescriptor();
Chat_pbTable.CHATMSG_MSGDATA_FIELD = protobuf.FieldDescriptor();

Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_NONE_ENUM.name = "CHAT_ROOM_NONE"
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_NONE_ENUM.index = 0
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_NONE_ENUM.number = 0
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_WORLD_ENUM.name = "CHAT_ROOM_WORLD"
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_WORLD_ENUM.index = 1
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_WORLD_ENUM.number = 901
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_TEAM_ENUM.name = "CHAT_ROOM_TEAM"
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_TEAM_ENUM.index = 2
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_TEAM_ENUM.number = 902
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_GANG_ENUM.name = "CHAT_ROOM_GANG"
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_GANG_ENUM.index = 3
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_GANG_ENUM.number = 903
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_PROFESSION_ENUM.name = "CHAT_ROOM_PROFESSION"
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_PROFESSION_ENUM.index = 4
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_PROFESSION_ENUM.number = 904
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_SCENE_ENUM.name = "CHAT_ROOM_SCENE"
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_SCENE_ENUM.index = 5
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_SCENE_ENUM.number = 905
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_NEW_ENUM.name = "CHAT_ROOM_NEW"
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_NEW_ENUM.index = 6
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_NEW_ENUM.number = 906
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_CITY_ENUM.name = "CHAT_ROOM_CITY"
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_CITY_ENUM.index = 7
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_CITY_ENUM.number = 907
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_SYSTEM_ENUM.name = "CHAT_ROOM_SYSTEM"
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_SYSTEM_ENUM.index = 8
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_SYSTEM_ENUM.number = 908
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_BULLET_ENUM.name = "CHAT_ROOM_BULLET"
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_BULLET_ENUM.index = 9
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_BULLET_ENUM.number = 9
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_GROUP_TEMP_ENUM.name = "CHAT_ROOM_GROUP_TEMP"
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_GROUP_TEMP_ENUM.index = 10
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_GROUP_TEMP_ENUM.number = 11
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_GROUP_FRIEND_ENUM.name = "CHAT_ROOM_GROUP_FRIEND"
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_GROUP_FRIEND_ENUM.index = 11
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_GROUP_FRIEND_ENUM.number = 12
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_NOTICE_SINGLE_ENUM.name = "CHAT_ROOM_NOTICE_SINGLE"
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_NOTICE_SINGLE_ENUM.index = 12
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_NOTICE_SINGLE_ENUM.number = 13
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_NOTICE_GLOBAL_ENUM.name = "CHAT_ROOM_NOTICE_GLOBAL"
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_NOTICE_GLOBAL_ENUM.index = 13
Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_NOTICE_GLOBAL_ENUM.number = 14
Chat_pbTable.CHATROOMTYPE.name = "ChatRoomType"
Chat_pbTable.CHATROOMTYPE.full_name = ".ChatRoomType"
Chat_pbTable.CHATROOMTYPE.values = {Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_NONE_ENUM,Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_WORLD_ENUM,Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_TEAM_ENUM,Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_GANG_ENUM,Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_PROFESSION_ENUM,Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_SCENE_ENUM,Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_NEW_ENUM,Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_CITY_ENUM,Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_SYSTEM_ENUM,Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_BULLET_ENUM,Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_GROUP_TEMP_ENUM,Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_GROUP_FRIEND_ENUM,Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_NOTICE_SINGLE_ENUM,Chat_pbTable.CHATROOMTYPE_CHAT_ROOM_NOTICE_GLOBAL_ENUM}
Chat_pbTable.CHATMSGTYPE_CHATMSG_BULLET_ADD_ENUM.name = "CHATMSG_BULLET_ADD"
Chat_pbTable.CHATMSGTYPE_CHATMSG_BULLET_ADD_ENUM.index = 0
Chat_pbTable.CHATMSGTYPE_CHATMSG_BULLET_ADD_ENUM.number = 1
Chat_pbTable.CHATMSGTYPE_CHATMSG_BULLET_THUMBUP_TRANSMIT_ENUM.name = "CHATMSG_BULLET_THUMBUP_TRANSMIT"
Chat_pbTable.CHATMSGTYPE_CHATMSG_BULLET_THUMBUP_TRANSMIT_ENUM.index = 1
Chat_pbTable.CHATMSGTYPE_CHATMSG_BULLET_THUMBUP_TRANSMIT_ENUM.number = 2
Chat_pbTable.CHATMSGTYPE_CHATMSG_BULLET_COMMENT_TRANSMIT_ENUM.name = "CHATMSG_BULLET_COMMENT_TRANSMIT"
Chat_pbTable.CHATMSGTYPE_CHATMSG_BULLET_COMMENT_TRANSMIT_ENUM.index = 2
Chat_pbTable.CHATMSGTYPE_CHATMSG_BULLET_COMMENT_TRANSMIT_ENUM.number = 3
Chat_pbTable.CHATMSGTYPE_CHATMSG_COMMON_ENUM.name = "CHATMSG_COMMON"
Chat_pbTable.CHATMSGTYPE_CHATMSG_COMMON_ENUM.index = 3
Chat_pbTable.CHATMSGTYPE_CHATMSG_COMMON_ENUM.number = 4
Chat_pbTable.CHATMSGTYPE_CHATMSG_FRIEND_PRIVATE_ENUM.name = "CHATMSG_FRIEND_PRIVATE"
Chat_pbTable.CHATMSGTYPE_CHATMSG_FRIEND_PRIVATE_ENUM.index = 4
Chat_pbTable.CHATMSGTYPE_CHATMSG_FRIEND_PRIVATE_ENUM.number = 5
Chat_pbTable.CHATMSGTYPE_CHATMSG_TEAM_PRIVATE_ENUM.name = "CHATMSG_TEAM_PRIVATE"
Chat_pbTable.CHATMSGTYPE_CHATMSG_TEAM_PRIVATE_ENUM.index = 5
Chat_pbTable.CHATMSGTYPE_CHATMSG_TEAM_PRIVATE_ENUM.number = 6
Chat_pbTable.CHATMSGTYPE_CHATMSG_FRIEND_QUN_ENUM.name = "CHATMSG_FRIEND_QUN"
Chat_pbTable.CHATMSGTYPE_CHATMSG_FRIEND_QUN_ENUM.index = 6
Chat_pbTable.CHATMSGTYPE_CHATMSG_FRIEND_QUN_ENUM.number = 7
Chat_pbTable.CHATMSGTYPE_CHATMSG_PAINT_ENUM.name = "CHATMSG_PAINT"
Chat_pbTable.CHATMSGTYPE_CHATMSG_PAINT_ENUM.index = 7
Chat_pbTable.CHATMSGTYPE_CHATMSG_PAINT_ENUM.number = 8
Chat_pbTable.CHATMSGTYPE.name = "ChatMsgType"
Chat_pbTable.CHATMSGTYPE.full_name = ".ChatMsgType"
Chat_pbTable.CHATMSGTYPE.values = {Chat_pbTable.CHATMSGTYPE_CHATMSG_BULLET_ADD_ENUM,Chat_pbTable.CHATMSGTYPE_CHATMSG_BULLET_THUMBUP_TRANSMIT_ENUM,Chat_pbTable.CHATMSGTYPE_CHATMSG_BULLET_COMMENT_TRANSMIT_ENUM,Chat_pbTable.CHATMSGTYPE_CHATMSG_COMMON_ENUM,Chat_pbTable.CHATMSGTYPE_CHATMSG_FRIEND_PRIVATE_ENUM,Chat_pbTable.CHATMSGTYPE_CHATMSG_TEAM_PRIVATE_ENUM,Chat_pbTable.CHATMSGTYPE_CHATMSG_FRIEND_QUN_ENUM,Chat_pbTable.CHATMSGTYPE_CHATMSG_PAINT_ENUM}
Chat_pbTable.CHATMSGSENDER_SENDERID_FIELD.name = "senderID"
Chat_pbTable.CHATMSGSENDER_SENDERID_FIELD.full_name = ".ChatMsgSender.senderID"
Chat_pbTable.CHATMSGSENDER_SENDERID_FIELD.number = 1
Chat_pbTable.CHATMSGSENDER_SENDERID_FIELD.index = 0
Chat_pbTable.CHATMSGSENDER_SENDERID_FIELD.label = 1
Chat_pbTable.CHATMSGSENDER_SENDERID_FIELD.has_default_value = false
Chat_pbTable.CHATMSGSENDER_SENDERID_FIELD.default_value = ""
Chat_pbTable.CHATMSGSENDER_SENDERID_FIELD.type = 9
Chat_pbTable.CHATMSGSENDER_SENDERID_FIELD.cpp_type = 9

Chat_pbTable.CHATMSGSENDER_SENDERLEVEL_FIELD.name = "senderLevel"
Chat_pbTable.CHATMSGSENDER_SENDERLEVEL_FIELD.full_name = ".ChatMsgSender.senderLevel"
Chat_pbTable.CHATMSGSENDER_SENDERLEVEL_FIELD.number = 2
Chat_pbTable.CHATMSGSENDER_SENDERLEVEL_FIELD.index = 1
Chat_pbTable.CHATMSGSENDER_SENDERLEVEL_FIELD.label = 1
Chat_pbTable.CHATMSGSENDER_SENDERLEVEL_FIELD.has_default_value = false
Chat_pbTable.CHATMSGSENDER_SENDERLEVEL_FIELD.default_value = 0
Chat_pbTable.CHATMSGSENDER_SENDERLEVEL_FIELD.type = 5
Chat_pbTable.CHATMSGSENDER_SENDERLEVEL_FIELD.cpp_type = 1

Chat_pbTable.CHATMSGSENDER_SENDERNAME_FIELD.name = "senderName"
Chat_pbTable.CHATMSGSENDER_SENDERNAME_FIELD.full_name = ".ChatMsgSender.senderName"
Chat_pbTable.CHATMSGSENDER_SENDERNAME_FIELD.number = 3
Chat_pbTable.CHATMSGSENDER_SENDERNAME_FIELD.index = 2
Chat_pbTable.CHATMSGSENDER_SENDERNAME_FIELD.label = 1
Chat_pbTable.CHATMSGSENDER_SENDERNAME_FIELD.has_default_value = false
Chat_pbTable.CHATMSGSENDER_SENDERNAME_FIELD.default_value = ""
Chat_pbTable.CHATMSGSENDER_SENDERNAME_FIELD.type = 9
Chat_pbTable.CHATMSGSENDER_SENDERNAME_FIELD.cpp_type = 9

Chat_pbTable.CHATMSGSENDER_SENDERDETAIL_FIELD.name = "senderDetail"
Chat_pbTable.CHATMSGSENDER_SENDERDETAIL_FIELD.full_name = ".ChatMsgSender.senderDetail"
Chat_pbTable.CHATMSGSENDER_SENDERDETAIL_FIELD.number = 4
Chat_pbTable.CHATMSGSENDER_SENDERDETAIL_FIELD.index = 3
Chat_pbTable.CHATMSGSENDER_SENDERDETAIL_FIELD.label = 1
Chat_pbTable.CHATMSGSENDER_SENDERDETAIL_FIELD.has_default_value = false
Chat_pbTable.CHATMSGSENDER_SENDERDETAIL_FIELD.default_value = ""
Chat_pbTable.CHATMSGSENDER_SENDERDETAIL_FIELD.type = 9
Chat_pbTable.CHATMSGSENDER_SENDERDETAIL_FIELD.cpp_type = 9

Chat_pbTable.CHATMSGSENDER.name = "ChatMsgSender"
Chat_pbTable.CHATMSGSENDER.full_name = ".ChatMsgSender"
Chat_pbTable.CHATMSGSENDER.nested_types = {}
Chat_pbTable.CHATMSGSENDER.enum_types = {}
Chat_pbTable.CHATMSGSENDER.fields = {Chat_pbTable.CHATMSGSENDER_SENDERID_FIELD, Chat_pbTable.CHATMSGSENDER_SENDERLEVEL_FIELD, Chat_pbTable.CHATMSGSENDER_SENDERNAME_FIELD, Chat_pbTable.CHATMSGSENDER_SENDERDETAIL_FIELD}
Chat_pbTable.CHATMSGSENDER.is_extendable = false
Chat_pbTable.CHATMSGSENDER.extensions = {}

Chat_pbTable.MSGLINKDESCEMOJI_NAME_FIELD.name = "name"
Chat_pbTable.MSGLINKDESCEMOJI_NAME_FIELD.full_name = ".MsgLinkDescEmoji.name"
Chat_pbTable.MSGLINKDESCEMOJI_NAME_FIELD.number = 1
Chat_pbTable.MSGLINKDESCEMOJI_NAME_FIELD.index = 0
Chat_pbTable.MSGLINKDESCEMOJI_NAME_FIELD.label = 1
Chat_pbTable.MSGLINKDESCEMOJI_NAME_FIELD.has_default_value = false
Chat_pbTable.MSGLINKDESCEMOJI_NAME_FIELD.default_value = ""
Chat_pbTable.MSGLINKDESCEMOJI_NAME_FIELD.type = 9
Chat_pbTable.MSGLINKDESCEMOJI_NAME_FIELD.cpp_type = 9

Chat_pbTable.MSGLINKDESCEMOJI.name = "MsgLinkDescEmoji"
Chat_pbTable.MSGLINKDESCEMOJI.full_name = ".MsgLinkDescEmoji"
Chat_pbTable.MSGLINKDESCEMOJI.nested_types = {}
Chat_pbTable.MSGLINKDESCEMOJI.enum_types = {}
Chat_pbTable.MSGLINKDESCEMOJI.fields = {Chat_pbTable.MSGLINKDESCEMOJI_NAME_FIELD}
Chat_pbTable.MSGLINKDESCEMOJI.is_extendable = false
Chat_pbTable.MSGLINKDESCEMOJI.extensions = {}

Chat_pbTable.MSGLINKDESCTEXT_COLOR_FIELD.name = "color"
Chat_pbTable.MSGLINKDESCTEXT_COLOR_FIELD.full_name = ".MsgLinkDescText.color"
Chat_pbTable.MSGLINKDESCTEXT_COLOR_FIELD.number = 1
Chat_pbTable.MSGLINKDESCTEXT_COLOR_FIELD.index = 0
Chat_pbTable.MSGLINKDESCTEXT_COLOR_FIELD.label = 1
Chat_pbTable.MSGLINKDESCTEXT_COLOR_FIELD.has_default_value = false
Chat_pbTable.MSGLINKDESCTEXT_COLOR_FIELD.default_value = ""
Chat_pbTable.MSGLINKDESCTEXT_COLOR_FIELD.type = 9
Chat_pbTable.MSGLINKDESCTEXT_COLOR_FIELD.cpp_type = 9

Chat_pbTable.MSGLINKDESCTEXT.name = "MsgLinkDescText"
Chat_pbTable.MSGLINKDESCTEXT.full_name = ".MsgLinkDescText"
Chat_pbTable.MSGLINKDESCTEXT.nested_types = {}
Chat_pbTable.MSGLINKDESCTEXT.enum_types = {}
Chat_pbTable.MSGLINKDESCTEXT.fields = {Chat_pbTable.MSGLINKDESCTEXT_COLOR_FIELD}
Chat_pbTable.MSGLINKDESCTEXT.is_extendable = false
Chat_pbTable.MSGLINKDESCTEXT.extensions = {}

Chat_pbTable.MSGLINKDESCTEXTURE_NAME_FIELD.name = "name"
Chat_pbTable.MSGLINKDESCTEXTURE_NAME_FIELD.full_name = ".MsgLinkDescTexture.name"
Chat_pbTable.MSGLINKDESCTEXTURE_NAME_FIELD.number = 1
Chat_pbTable.MSGLINKDESCTEXTURE_NAME_FIELD.index = 0
Chat_pbTable.MSGLINKDESCTEXTURE_NAME_FIELD.label = 1
Chat_pbTable.MSGLINKDESCTEXTURE_NAME_FIELD.has_default_value = false
Chat_pbTable.MSGLINKDESCTEXTURE_NAME_FIELD.default_value = ""
Chat_pbTable.MSGLINKDESCTEXTURE_NAME_FIELD.type = 9
Chat_pbTable.MSGLINKDESCTEXTURE_NAME_FIELD.cpp_type = 9

Chat_pbTable.MSGLINKDESCTEXTURE.name = "MsgLinkDescTexture"
Chat_pbTable.MSGLINKDESCTEXTURE.full_name = ".MsgLinkDescTexture"
Chat_pbTable.MSGLINKDESCTEXTURE.nested_types = {}
Chat_pbTable.MSGLINKDESCTEXTURE.enum_types = {}
Chat_pbTable.MSGLINKDESCTEXTURE.fields = {Chat_pbTable.MSGLINKDESCTEXTURE_NAME_FIELD}
Chat_pbTable.MSGLINKDESCTEXTURE.is_extendable = false
Chat_pbTable.MSGLINKDESCTEXTURE.extensions = {}

Chat_pbTable.MSGLINKDESC_EMOJIDESC_FIELD.name = "emojiDesc"
Chat_pbTable.MSGLINKDESC_EMOJIDESC_FIELD.full_name = ".MsgLinkDesc.emojiDesc"
Chat_pbTable.MSGLINKDESC_EMOJIDESC_FIELD.number = 1
Chat_pbTable.MSGLINKDESC_EMOJIDESC_FIELD.index = 0
Chat_pbTable.MSGLINKDESC_EMOJIDESC_FIELD.label = 1
Chat_pbTable.MSGLINKDESC_EMOJIDESC_FIELD.has_default_value = false
Chat_pbTable.MSGLINKDESC_EMOJIDESC_FIELD.default_value = nil
Chat_pbTable.MSGLINKDESC_EMOJIDESC_FIELD.message_type = Chat_pbTable.MSGLINKDESCEMOJI
Chat_pbTable.MSGLINKDESC_EMOJIDESC_FIELD.type = 11
Chat_pbTable.MSGLINKDESC_EMOJIDESC_FIELD.cpp_type = 10

Chat_pbTable.MSGLINKDESC_TEXTDESC_FIELD.name = "textDesc"
Chat_pbTable.MSGLINKDESC_TEXTDESC_FIELD.full_name = ".MsgLinkDesc.textDesc"
Chat_pbTable.MSGLINKDESC_TEXTDESC_FIELD.number = 2
Chat_pbTable.MSGLINKDESC_TEXTDESC_FIELD.index = 1
Chat_pbTable.MSGLINKDESC_TEXTDESC_FIELD.label = 1
Chat_pbTable.MSGLINKDESC_TEXTDESC_FIELD.has_default_value = false
Chat_pbTable.MSGLINKDESC_TEXTDESC_FIELD.default_value = nil
Chat_pbTable.MSGLINKDESC_TEXTDESC_FIELD.message_type = Chat_pbTable.MSGLINKDESCTEXT
Chat_pbTable.MSGLINKDESC_TEXTDESC_FIELD.type = 11
Chat_pbTable.MSGLINKDESC_TEXTDESC_FIELD.cpp_type = 10

Chat_pbTable.MSGLINKDESC_TEXTUREDESC_FIELD.name = "textureDesc"
Chat_pbTable.MSGLINKDESC_TEXTUREDESC_FIELD.full_name = ".MsgLinkDesc.textureDesc"
Chat_pbTable.MSGLINKDESC_TEXTUREDESC_FIELD.number = 3
Chat_pbTable.MSGLINKDESC_TEXTUREDESC_FIELD.index = 2
Chat_pbTable.MSGLINKDESC_TEXTUREDESC_FIELD.label = 1
Chat_pbTable.MSGLINKDESC_TEXTUREDESC_FIELD.has_default_value = false
Chat_pbTable.MSGLINKDESC_TEXTUREDESC_FIELD.default_value = nil
Chat_pbTable.MSGLINKDESC_TEXTUREDESC_FIELD.message_type = Chat_pbTable.MSGLINKDESCTEXTURE
Chat_pbTable.MSGLINKDESC_TEXTUREDESC_FIELD.type = 11
Chat_pbTable.MSGLINKDESC_TEXTUREDESC_FIELD.cpp_type = 10

Chat_pbTable.MSGLINKDESC.name = "MsgLinkDesc"
Chat_pbTable.MSGLINKDESC.full_name = ".MsgLinkDesc"
Chat_pbTable.MSGLINKDESC.nested_types = {}
Chat_pbTable.MSGLINKDESC.enum_types = {}
Chat_pbTable.MSGLINKDESC.fields = {Chat_pbTable.MSGLINKDESC_EMOJIDESC_FIELD, Chat_pbTable.MSGLINKDESC_TEXTDESC_FIELD, Chat_pbTable.MSGLINKDESC_TEXTUREDESC_FIELD}
Chat_pbTable.MSGLINKDESC.is_extendable = false
Chat_pbTable.MSGLINKDESC.extensions = {}

Chat_pbTable.CHATMSGLINK_LINKTYPE_AT_ENUM.name = "AT"
Chat_pbTable.CHATMSGLINK_LINKTYPE_AT_ENUM.index = 0
Chat_pbTable.CHATMSGLINK_LINKTYPE_AT_ENUM.number = 0
Chat_pbTable.CHATMSGLINK_LINKTYPE_PLAYER_ENUM.name = "PLAYER"
Chat_pbTable.CHATMSGLINK_LINKTYPE_PLAYER_ENUM.index = 1
Chat_pbTable.CHATMSGLINK_LINKTYPE_PLAYER_ENUM.number = 1
Chat_pbTable.CHATMSGLINK_LINKTYPE_PAINT_ENUM.name = "PAINT"
Chat_pbTable.CHATMSGLINK_LINKTYPE_PAINT_ENUM.index = 2
Chat_pbTable.CHATMSGLINK_LINKTYPE_PAINT_ENUM.number = 2
Chat_pbTable.CHATMSGLINK_LINKTYPE_EMOJI_ENUM.name = "EMOJI"
Chat_pbTable.CHATMSGLINK_LINKTYPE_EMOJI_ENUM.index = 3
Chat_pbTable.CHATMSGLINK_LINKTYPE_EMOJI_ENUM.number = 3
Chat_pbTable.CHATMSGLINK_LINKTYPE_EMOJI_CUSTOM_ENUM.name = "EMOJI_CUSTOM"
Chat_pbTable.CHATMSGLINK_LINKTYPE_EMOJI_CUSTOM_ENUM.index = 4
Chat_pbTable.CHATMSGLINK_LINKTYPE_EMOJI_CUSTOM_ENUM.number = 4
Chat_pbTable.CHATMSGLINK_LINKTYPE_ITEM_ENUM.name = "ITEM"
Chat_pbTable.CHATMSGLINK_LINKTYPE_ITEM_ENUM.index = 5
Chat_pbTable.CHATMSGLINK_LINKTYPE_ITEM_ENUM.number = 5
Chat_pbTable.CHATMSGLINK_LINKTYPE.name = "LinkType"
Chat_pbTable.CHATMSGLINK_LINKTYPE.full_name = ".ChatMsgLink.LinkType"
Chat_pbTable.CHATMSGLINK_LINKTYPE.values = {Chat_pbTable.CHATMSGLINK_LINKTYPE_AT_ENUM,Chat_pbTable.CHATMSGLINK_LINKTYPE_PLAYER_ENUM,Chat_pbTable.CHATMSGLINK_LINKTYPE_PAINT_ENUM,Chat_pbTable.CHATMSGLINK_LINKTYPE_EMOJI_ENUM,Chat_pbTable.CHATMSGLINK_LINKTYPE_EMOJI_CUSTOM_ENUM,Chat_pbTable.CHATMSGLINK_LINKTYPE_ITEM_ENUM}
Chat_pbTable.CHATMSGLINK_LINKTYPE_FIELD.name = "linkType"
Chat_pbTable.CHATMSGLINK_LINKTYPE_FIELD.full_name = ".ChatMsgLink.linkType"
Chat_pbTable.CHATMSGLINK_LINKTYPE_FIELD.number = 1
Chat_pbTable.CHATMSGLINK_LINKTYPE_FIELD.index = 0
Chat_pbTable.CHATMSGLINK_LINKTYPE_FIELD.label = 1
Chat_pbTable.CHATMSGLINK_LINKTYPE_FIELD.has_default_value = false
Chat_pbTable.CHATMSGLINK_LINKTYPE_FIELD.default_value = 0
Chat_pbTable.CHATMSGLINK_LINKTYPE_FIELD.enum_type = Chat_pbTable.CHATMSGLINK_LINKTYPE
Chat_pbTable.CHATMSGLINK_LINKTYPE_FIELD.type = 14
Chat_pbTable.CHATMSGLINK_LINKTYPE_FIELD.cpp_type = 8

Chat_pbTable.CHATMSGLINK_INTPARAMS_FIELD.name = "intParams"
Chat_pbTable.CHATMSGLINK_INTPARAMS_FIELD.full_name = ".ChatMsgLink.intParams"
Chat_pbTable.CHATMSGLINK_INTPARAMS_FIELD.number = 2
Chat_pbTable.CHATMSGLINK_INTPARAMS_FIELD.index = 1
Chat_pbTable.CHATMSGLINK_INTPARAMS_FIELD.label = 3
Chat_pbTable.CHATMSGLINK_INTPARAMS_FIELD.has_default_value = false
Chat_pbTable.CHATMSGLINK_INTPARAMS_FIELD.default_value = {}
Chat_pbTable.CHATMSGLINK_INTPARAMS_FIELD.type = 5
Chat_pbTable.CHATMSGLINK_INTPARAMS_FIELD.cpp_type = 1

Chat_pbTable.CHATMSGLINK_STRPARAMS_FIELD.name = "strParams"
Chat_pbTable.CHATMSGLINK_STRPARAMS_FIELD.full_name = ".ChatMsgLink.strParams"
Chat_pbTable.CHATMSGLINK_STRPARAMS_FIELD.number = 3
Chat_pbTable.CHATMSGLINK_STRPARAMS_FIELD.index = 2
Chat_pbTable.CHATMSGLINK_STRPARAMS_FIELD.label = 3
Chat_pbTable.CHATMSGLINK_STRPARAMS_FIELD.has_default_value = false
Chat_pbTable.CHATMSGLINK_STRPARAMS_FIELD.default_value = {}
Chat_pbTable.CHATMSGLINK_STRPARAMS_FIELD.type = 9
Chat_pbTable.CHATMSGLINK_STRPARAMS_FIELD.cpp_type = 9

Chat_pbTable.CHATMSGLINK_BYTEPARAMS_FIELD.name = "byteParams"
Chat_pbTable.CHATMSGLINK_BYTEPARAMS_FIELD.full_name = ".ChatMsgLink.byteParams"
Chat_pbTable.CHATMSGLINK_BYTEPARAMS_FIELD.number = 4
Chat_pbTable.CHATMSGLINK_BYTEPARAMS_FIELD.index = 3
Chat_pbTable.CHATMSGLINK_BYTEPARAMS_FIELD.label = 3
Chat_pbTable.CHATMSGLINK_BYTEPARAMS_FIELD.has_default_value = false
Chat_pbTable.CHATMSGLINK_BYTEPARAMS_FIELD.default_value = {}
Chat_pbTable.CHATMSGLINK_BYTEPARAMS_FIELD.type = 12
Chat_pbTable.CHATMSGLINK_BYTEPARAMS_FIELD.cpp_type = 9

Chat_pbTable.CHATMSGLINK_CONTENT_FIELD.name = "content"
Chat_pbTable.CHATMSGLINK_CONTENT_FIELD.full_name = ".ChatMsgLink.content"
Chat_pbTable.CHATMSGLINK_CONTENT_FIELD.number = 5
Chat_pbTable.CHATMSGLINK_CONTENT_FIELD.index = 4
Chat_pbTable.CHATMSGLINK_CONTENT_FIELD.label = 1
Chat_pbTable.CHATMSGLINK_CONTENT_FIELD.has_default_value = false
Chat_pbTable.CHATMSGLINK_CONTENT_FIELD.default_value = ""
Chat_pbTable.CHATMSGLINK_CONTENT_FIELD.type = 9
Chat_pbTable.CHATMSGLINK_CONTENT_FIELD.cpp_type = 9

Chat_pbTable.CHATMSGLINK_ISVALID_FIELD.name = "isValid"
Chat_pbTable.CHATMSGLINK_ISVALID_FIELD.full_name = ".ChatMsgLink.isValid"
Chat_pbTable.CHATMSGLINK_ISVALID_FIELD.number = 6
Chat_pbTable.CHATMSGLINK_ISVALID_FIELD.index = 5
Chat_pbTable.CHATMSGLINK_ISVALID_FIELD.label = 1
Chat_pbTable.CHATMSGLINK_ISVALID_FIELD.has_default_value = false
Chat_pbTable.CHATMSGLINK_ISVALID_FIELD.default_value = false
Chat_pbTable.CHATMSGLINK_ISVALID_FIELD.type = 8
Chat_pbTable.CHATMSGLINK_ISVALID_FIELD.cpp_type = 7

Chat_pbTable.CHATMSGLINK_LINKDESC_FIELD.name = "linkDesc"
Chat_pbTable.CHATMSGLINK_LINKDESC_FIELD.full_name = ".ChatMsgLink.linkDesc"
Chat_pbTable.CHATMSGLINK_LINKDESC_FIELD.number = 7
Chat_pbTable.CHATMSGLINK_LINKDESC_FIELD.index = 6
Chat_pbTable.CHATMSGLINK_LINKDESC_FIELD.label = 1
Chat_pbTable.CHATMSGLINK_LINKDESC_FIELD.has_default_value = false
Chat_pbTable.CHATMSGLINK_LINKDESC_FIELD.default_value = nil
Chat_pbTable.CHATMSGLINK_LINKDESC_FIELD.message_type = Chat_pbTable.MSGLINKDESC
Chat_pbTable.CHATMSGLINK_LINKDESC_FIELD.type = 11
Chat_pbTable.CHATMSGLINK_LINKDESC_FIELD.cpp_type = 10

Chat_pbTable.CHATMSGLINK_STATICID_FIELD.name = "staticID"
Chat_pbTable.CHATMSGLINK_STATICID_FIELD.full_name = ".ChatMsgLink.staticID"
Chat_pbTable.CHATMSGLINK_STATICID_FIELD.number = 8
Chat_pbTable.CHATMSGLINK_STATICID_FIELD.index = 7
Chat_pbTable.CHATMSGLINK_STATICID_FIELD.label = 1
Chat_pbTable.CHATMSGLINK_STATICID_FIELD.has_default_value = false
Chat_pbTable.CHATMSGLINK_STATICID_FIELD.default_value = 0
Chat_pbTable.CHATMSGLINK_STATICID_FIELD.type = 5
Chat_pbTable.CHATMSGLINK_STATICID_FIELD.cpp_type = 1

Chat_pbTable.CHATMSGLINK_DYNAMICID_FIELD.name = "dynamicID"
Chat_pbTable.CHATMSGLINK_DYNAMICID_FIELD.full_name = ".ChatMsgLink.dynamicID"
Chat_pbTable.CHATMSGLINK_DYNAMICID_FIELD.number = 9
Chat_pbTable.CHATMSGLINK_DYNAMICID_FIELD.index = 8
Chat_pbTable.CHATMSGLINK_DYNAMICID_FIELD.label = 1
Chat_pbTable.CHATMSGLINK_DYNAMICID_FIELD.has_default_value = false
Chat_pbTable.CHATMSGLINK_DYNAMICID_FIELD.default_value = 0
Chat_pbTable.CHATMSGLINK_DYNAMICID_FIELD.type = 5
Chat_pbTable.CHATMSGLINK_DYNAMICID_FIELD.cpp_type = 1

Chat_pbTable.CHATMSGLINK_CONTENTAUTOID_FIELD.name = "contentAutoId"
Chat_pbTable.CHATMSGLINK_CONTENTAUTOID_FIELD.full_name = ".ChatMsgLink.contentAutoId"
Chat_pbTable.CHATMSGLINK_CONTENTAUTOID_FIELD.number = 10
Chat_pbTable.CHATMSGLINK_CONTENTAUTOID_FIELD.index = 9
Chat_pbTable.CHATMSGLINK_CONTENTAUTOID_FIELD.label = 1
Chat_pbTable.CHATMSGLINK_CONTENTAUTOID_FIELD.has_default_value = false
Chat_pbTable.CHATMSGLINK_CONTENTAUTOID_FIELD.default_value = 0
Chat_pbTable.CHATMSGLINK_CONTENTAUTOID_FIELD.type = 5
Chat_pbTable.CHATMSGLINK_CONTENTAUTOID_FIELD.cpp_type = 1

Chat_pbTable.CHATMSGLINK_CONTENTWITHID_FIELD.name = "contentWithId"
Chat_pbTable.CHATMSGLINK_CONTENTWITHID_FIELD.full_name = ".ChatMsgLink.contentWithId"
Chat_pbTable.CHATMSGLINK_CONTENTWITHID_FIELD.number = 11
Chat_pbTable.CHATMSGLINK_CONTENTWITHID_FIELD.index = 10
Chat_pbTable.CHATMSGLINK_CONTENTWITHID_FIELD.label = 1
Chat_pbTable.CHATMSGLINK_CONTENTWITHID_FIELD.has_default_value = false
Chat_pbTable.CHATMSGLINK_CONTENTWITHID_FIELD.default_value = ""
Chat_pbTable.CHATMSGLINK_CONTENTWITHID_FIELD.type = 9
Chat_pbTable.CHATMSGLINK_CONTENTWITHID_FIELD.cpp_type = 9

Chat_pbTable.CHATMSGLINK.name = "ChatMsgLink"
Chat_pbTable.CHATMSGLINK.full_name = ".ChatMsgLink"
Chat_pbTable.CHATMSGLINK.nested_types = {}
Chat_pbTable.CHATMSGLINK.enum_types = {Chat_pbTable.CHATMSGLINK_LINKTYPE}
Chat_pbTable.CHATMSGLINK.fields = {Chat_pbTable.CHATMSGLINK_LINKTYPE_FIELD, Chat_pbTable.CHATMSGLINK_INTPARAMS_FIELD, Chat_pbTable.CHATMSGLINK_STRPARAMS_FIELD, Chat_pbTable.CHATMSGLINK_BYTEPARAMS_FIELD, Chat_pbTable.CHATMSGLINK_CONTENT_FIELD, Chat_pbTable.CHATMSGLINK_ISVALID_FIELD, Chat_pbTable.CHATMSGLINK_LINKDESC_FIELD, Chat_pbTable.CHATMSGLINK_STATICID_FIELD, Chat_pbTable.CHATMSGLINK_DYNAMICID_FIELD, Chat_pbTable.CHATMSGLINK_CONTENTAUTOID_FIELD, Chat_pbTable.CHATMSGLINK_CONTENTWITHID_FIELD}
Chat_pbTable.CHATMSGLINK.is_extendable = false
Chat_pbTable.CHATMSGLINK.extensions = {}

Chat_pbTable.CHATMSGCOMMON_SENDER_FIELD.name = "sender"
Chat_pbTable.CHATMSGCOMMON_SENDER_FIELD.full_name = ".ChatMsgCommon.sender"
Chat_pbTable.CHATMSGCOMMON_SENDER_FIELD.number = 1
Chat_pbTable.CHATMSGCOMMON_SENDER_FIELD.index = 0
Chat_pbTable.CHATMSGCOMMON_SENDER_FIELD.label = 1
Chat_pbTable.CHATMSGCOMMON_SENDER_FIELD.has_default_value = false
Chat_pbTable.CHATMSGCOMMON_SENDER_FIELD.default_value = nil
Chat_pbTable.CHATMSGCOMMON_SENDER_FIELD.message_type = Chat_pbTable.CHATMSGSENDER
Chat_pbTable.CHATMSGCOMMON_SENDER_FIELD.type = 11
Chat_pbTable.CHATMSGCOMMON_SENDER_FIELD.cpp_type = 10

Chat_pbTable.CHATMSGCOMMON_ROOMTYPE_FIELD.name = "roomType"
Chat_pbTable.CHATMSGCOMMON_ROOMTYPE_FIELD.full_name = ".ChatMsgCommon.roomType"
Chat_pbTable.CHATMSGCOMMON_ROOMTYPE_FIELD.number = 2
Chat_pbTable.CHATMSGCOMMON_ROOMTYPE_FIELD.index = 1
Chat_pbTable.CHATMSGCOMMON_ROOMTYPE_FIELD.label = 1
Chat_pbTable.CHATMSGCOMMON_ROOMTYPE_FIELD.has_default_value = false
Chat_pbTable.CHATMSGCOMMON_ROOMTYPE_FIELD.default_value = 0
Chat_pbTable.CHATMSGCOMMON_ROOMTYPE_FIELD.enum_type = Chat_pbTable.CHATROOMTYPE
Chat_pbTable.CHATMSGCOMMON_ROOMTYPE_FIELD.type = 14
Chat_pbTable.CHATMSGCOMMON_ROOMTYPE_FIELD.cpp_type = 8

Chat_pbTable.CHATMSGCOMMON_LINKS_FIELD.name = "links"
Chat_pbTable.CHATMSGCOMMON_LINKS_FIELD.full_name = ".ChatMsgCommon.links"
Chat_pbTable.CHATMSGCOMMON_LINKS_FIELD.number = 3
Chat_pbTable.CHATMSGCOMMON_LINKS_FIELD.index = 2
Chat_pbTable.CHATMSGCOMMON_LINKS_FIELD.label = 3
Chat_pbTable.CHATMSGCOMMON_LINKS_FIELD.has_default_value = false
Chat_pbTable.CHATMSGCOMMON_LINKS_FIELD.default_value = {}
Chat_pbTable.CHATMSGCOMMON_LINKS_FIELD.message_type = Chat_pbTable.CHATMSGLINK
Chat_pbTable.CHATMSGCOMMON_LINKS_FIELD.type = 11
Chat_pbTable.CHATMSGCOMMON_LINKS_FIELD.cpp_type = 10

Chat_pbTable.CHATMSGCOMMON_CONTENT_FIELD.name = "content"
Chat_pbTable.CHATMSGCOMMON_CONTENT_FIELD.full_name = ".ChatMsgCommon.content"
Chat_pbTable.CHATMSGCOMMON_CONTENT_FIELD.number = 4
Chat_pbTable.CHATMSGCOMMON_CONTENT_FIELD.index = 3
Chat_pbTable.CHATMSGCOMMON_CONTENT_FIELD.label = 1
Chat_pbTable.CHATMSGCOMMON_CONTENT_FIELD.has_default_value = false
Chat_pbTable.CHATMSGCOMMON_CONTENT_FIELD.default_value = ""
Chat_pbTable.CHATMSGCOMMON_CONTENT_FIELD.type = 9
Chat_pbTable.CHATMSGCOMMON_CONTENT_FIELD.cpp_type = 9

Chat_pbTable.CHATMSGCOMMON_CONTENTPREFIX_FIELD.name = "contentPrefix"
Chat_pbTable.CHATMSGCOMMON_CONTENTPREFIX_FIELD.full_name = ".ChatMsgCommon.contentPrefix"
Chat_pbTable.CHATMSGCOMMON_CONTENTPREFIX_FIELD.number = 5
Chat_pbTable.CHATMSGCOMMON_CONTENTPREFIX_FIELD.index = 4
Chat_pbTable.CHATMSGCOMMON_CONTENTPREFIX_FIELD.label = 1
Chat_pbTable.CHATMSGCOMMON_CONTENTPREFIX_FIELD.has_default_value = false
Chat_pbTable.CHATMSGCOMMON_CONTENTPREFIX_FIELD.default_value = ""
Chat_pbTable.CHATMSGCOMMON_CONTENTPREFIX_FIELD.type = 9
Chat_pbTable.CHATMSGCOMMON_CONTENTPREFIX_FIELD.cpp_type = 9

Chat_pbTable.CHATMSGCOMMON_CONTENTPOSTFIX_FIELD.name = "contentPostfix"
Chat_pbTable.CHATMSGCOMMON_CONTENTPOSTFIX_FIELD.full_name = ".ChatMsgCommon.contentPostfix"
Chat_pbTable.CHATMSGCOMMON_CONTENTPOSTFIX_FIELD.number = 6
Chat_pbTable.CHATMSGCOMMON_CONTENTPOSTFIX_FIELD.index = 5
Chat_pbTable.CHATMSGCOMMON_CONTENTPOSTFIX_FIELD.label = 1
Chat_pbTable.CHATMSGCOMMON_CONTENTPOSTFIX_FIELD.has_default_value = false
Chat_pbTable.CHATMSGCOMMON_CONTENTPOSTFIX_FIELD.default_value = ""
Chat_pbTable.CHATMSGCOMMON_CONTENTPOSTFIX_FIELD.type = 9
Chat_pbTable.CHATMSGCOMMON_CONTENTPOSTFIX_FIELD.cpp_type = 9

Chat_pbTable.CHATMSGCOMMON.name = "ChatMsgCommon"
Chat_pbTable.CHATMSGCOMMON.full_name = ".ChatMsgCommon"
Chat_pbTable.CHATMSGCOMMON.nested_types = {}
Chat_pbTable.CHATMSGCOMMON.enum_types = {}
Chat_pbTable.CHATMSGCOMMON.fields = {Chat_pbTable.CHATMSGCOMMON_SENDER_FIELD, Chat_pbTable.CHATMSGCOMMON_ROOMTYPE_FIELD, Chat_pbTable.CHATMSGCOMMON_LINKS_FIELD, Chat_pbTable.CHATMSGCOMMON_CONTENT_FIELD, Chat_pbTable.CHATMSGCOMMON_CONTENTPREFIX_FIELD, Chat_pbTable.CHATMSGCOMMON_CONTENTPOSTFIX_FIELD}
Chat_pbTable.CHATMSGCOMMON.is_extendable = false
Chat_pbTable.CHATMSGCOMMON.extensions = {}

Chat_pbTable.CHATMSG_MSGID_FIELD.name = "msgID"
Chat_pbTable.CHATMSG_MSGID_FIELD.full_name = ".ChatMsg.msgID"
Chat_pbTable.CHATMSG_MSGID_FIELD.number = 1
Chat_pbTable.CHATMSG_MSGID_FIELD.index = 0
Chat_pbTable.CHATMSG_MSGID_FIELD.label = 1
Chat_pbTable.CHATMSG_MSGID_FIELD.has_default_value = false
Chat_pbTable.CHATMSG_MSGID_FIELD.default_value = 0
Chat_pbTable.CHATMSG_MSGID_FIELD.type = 5
Chat_pbTable.CHATMSG_MSGID_FIELD.cpp_type = 1

Chat_pbTable.CHATMSG_MSGTYPE_FIELD.name = "msgType"
Chat_pbTable.CHATMSG_MSGTYPE_FIELD.full_name = ".ChatMsg.msgType"
Chat_pbTable.CHATMSG_MSGTYPE_FIELD.number = 2
Chat_pbTable.CHATMSG_MSGTYPE_FIELD.index = 1
Chat_pbTable.CHATMSG_MSGTYPE_FIELD.label = 1
Chat_pbTable.CHATMSG_MSGTYPE_FIELD.has_default_value = false
Chat_pbTable.CHATMSG_MSGTYPE_FIELD.default_value = 0
Chat_pbTable.CHATMSG_MSGTYPE_FIELD.enum_type = Chat_pbTable.CHATMSGTYPE
Chat_pbTable.CHATMSG_MSGTYPE_FIELD.type = 14
Chat_pbTable.CHATMSG_MSGTYPE_FIELD.cpp_type = 8

Chat_pbTable.CHATMSG_MSGDATA_FIELD.name = "msgData"
Chat_pbTable.CHATMSG_MSGDATA_FIELD.full_name = ".ChatMsg.msgData"
Chat_pbTable.CHATMSG_MSGDATA_FIELD.number = 3
Chat_pbTable.CHATMSG_MSGDATA_FIELD.index = 2
Chat_pbTable.CHATMSG_MSGDATA_FIELD.label = 1
Chat_pbTable.CHATMSG_MSGDATA_FIELD.has_default_value = false
Chat_pbTable.CHATMSG_MSGDATA_FIELD.default_value = ""
Chat_pbTable.CHATMSG_MSGDATA_FIELD.type = 12
Chat_pbTable.CHATMSG_MSGDATA_FIELD.cpp_type = 9

Chat_pbTable.CHATMSG.name = "ChatMsg"
Chat_pbTable.CHATMSG.full_name = ".ChatMsg"
Chat_pbTable.CHATMSG.nested_types = {}
Chat_pbTable.CHATMSG.enum_types = {}
Chat_pbTable.CHATMSG.fields = {Chat_pbTable.CHATMSG_MSGID_FIELD, Chat_pbTable.CHATMSG_MSGTYPE_FIELD, Chat_pbTable.CHATMSG_MSGDATA_FIELD}
Chat_pbTable.CHATMSG.is_extendable = false
Chat_pbTable.CHATMSG.extensions = {}


CHATMSG_BULLET_ADD = 1
CHATMSG_BULLET_COMMENT_TRANSMIT = 3
CHATMSG_BULLET_THUMBUP_TRANSMIT = 2
CHATMSG_COMMON = 4
CHATMSG_FRIEND_PRIVATE = 5
CHATMSG_FRIEND_QUN = 7
CHATMSG_PAINT = 8
CHATMSG_TEAM_PRIVATE = 6
CHAT_ROOM_BULLET = 9
CHAT_ROOM_CITY = 907
CHAT_ROOM_GANG = 903
CHAT_ROOM_GROUP_FRIEND = 12
CHAT_ROOM_GROUP_TEMP = 11
CHAT_ROOM_NEW = 906
CHAT_ROOM_NONE = 0
CHAT_ROOM_NOTICE_GLOBAL = 14
CHAT_ROOM_NOTICE_SINGLE = 13
CHAT_ROOM_PROFESSION = 904
CHAT_ROOM_SCENE = 905
CHAT_ROOM_SYSTEM = 908
CHAT_ROOM_TEAM = 902
CHAT_ROOM_WORLD = 901
ChatMsg = protobuf.Message(Chat_pbTable.CHATMSG)
ChatMsgCommon = protobuf.Message(Chat_pbTable.CHATMSGCOMMON)
ChatMsgLink = protobuf.Message(Chat_pbTable.CHATMSGLINK)
ChatMsgSender = protobuf.Message(Chat_pbTable.CHATMSGSENDER)
MsgLinkDesc = protobuf.Message(Chat_pbTable.MSGLINKDESC)
MsgLinkDescEmoji = protobuf.Message(Chat_pbTable.MSGLINKDESCEMOJI)
MsgLinkDescText = protobuf.Message(Chat_pbTable.MSGLINKDESCTEXT)
MsgLinkDescTexture = protobuf.Message(Chat_pbTable.MSGLINKDESCTEXTURE)


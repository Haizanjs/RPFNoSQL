/*
  File: fn_writeData.sqf
  Author: Heisen
  First Edit: 03/06/2018 (US)
  Desc:
    - SQF >> Extension writing data handling.
*/

params [
  ["_SavePathFolder",""],
  ["_SavePathFile",""],
  ["_SaveDataTitle",""],
  ["_saveDataContent",nil],
  ["_saveDataDataType",""]
];
  
private _RPFNoSQL_DataTypes = ["bool","boolean","string","str","array","number","scalar","object"];

if (_savePathFolder isEqualTo "") exitWith {
  diag_log "RPFNoSQL >> Error >> Write Data: Save Path Folder Not Defined";
};
if (_savePathFile isEqualTo "") exitWith {
	diag_log "RPFNoSQL >> Error >> Write Data: Save Path File not Defined";
};
if (_saveDataTitle isEqualTo "") exitWith {
	diag_log "RPFNoSQL >> Error >> Write Data: Save Data Title not Defined";
};
if (isNil _saveDataContent) exitWith {
	diag_log "RPFNoSQL >> Error >> Write Data: Save Data Content not defined/nil";
};
if (_saveDataDataType isEqualTo "") exitWith {
	diag_log "RPFNoSQL >> Error >> Write Data: Save Data Data Type not defined";
};
if !((toLower _saveDataDataType) IN _RPFNoSQL_DataTypes) exitWith {
	diag_log format["RPFNoSQL >> Error >> Write Data: Data Type not recognised.. please use [%1]",_RPFNoSQL_DataTypes joinString ""];
};
	
private _dataArray = [_savePathFolder,_savePathFile,_saveDataTitle,_saveDataContent,_savaDataDataType];

// Merge data array to string so in c# we can splitargs[<index>] select out of the given arguments..
"RPFNoSQL" callExtension (format["WriteData:%1",_dataArray joinString ":"]); 
	

// wait for bool return status
// c# check for public static string for passed bool true,false to str.
	

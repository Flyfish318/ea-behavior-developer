﻿/*
 * Created by SharpDevelop.
 * User: ctc0065
 * Date: 2017/12/09
 * Time: 12:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BehaviorDevelop.vo
{
	/// <summary>
	/// Description of ConnectorVO.
	/// </summary>
	public class ConnectorVO
	{
		public ConnectorVO()
		{
		}

		// 	Public Name ' As String
		/// <summary>名前</summary>
    	public string name { get; set; }
    	
    	//	Public AttributeGUID ' As String
		/// <summary>接続のguid</summary>
    	public string guid { get; set; }	

		/// <summary>接続の種類 (Dependency, Association, etc)</summary>
    	public string connectorType { get; set; }	
    	
		/// <summary>接続相手の要素guid</summary>
    	public string targetObjGuid { get; set; }	

		/// <summary>接続相手の要素名</summary>
    	public string targetObjName { get; set; }	

		/// <summary>接続元要素のguid</summary>
    	public string srcObjGuid { get; set; }	

		/// <summary>接続元要素の名前</summary>
    	public string srcObjName { get; set; }	
    	
		/// <summary>接続先要素のguid</summary>
    	public string destObjGuid { get; set; }	

		/// <summary>接続先要素の名前</summary>
    	public string destObjName { get; set; }	
    	
	}
}

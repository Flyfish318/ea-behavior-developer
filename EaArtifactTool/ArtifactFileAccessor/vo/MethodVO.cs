﻿using System;
using System.Collections.Generic;
using System.IO;

namespace ArtifactFileAccessor.vo
{
	/// <summary>
	/// Description of MethodVO.
	/// </summary>
	public class MethodVO : IComparable<MethodVO>
	{

		/// <summary>名前</summary>
    	public string name { get; set; }

		/// <summary>別名</summary>
    	public string alias { get; set; }

		/// <summary>操作のguid</summary>
    	public string guid { get; set; }

		/// <summary>操作のid</summary>
    	public int methodId { get; set; }

        /// <summary>操作のid</summary>
        public int elementId { get; set; }

        /// <summary>ノート</summary>
        public string notes { get; set; }

		/// <summary>振る舞い</summary>
    	public string behavior { get; set; }

		/// <summary>戻り型</summary>
    	public string returnType { get; set; }

		/// <summary>可視性</summary>
    	public string visibility { get; set; }

		/// <summary>並び順</summary>
    	public Int32 pos { get; set; }

		/// <summary>ステレオタイプ</summary>
    	public string stereoType { get; set; }

		/// <summary>ステレオタイプ</summary>
    	public Boolean isAbstract { get; set; }

		/// <summary>分類子のID(戻り値型)</summary>
    	public string classifierID { get; set; }

		/// <summary>コード</summary>
    	public string code { get; set; }

		/// <summary>並列性</summary>
    	public string concurrency { get; set; }

		/// <summary>定数</summary>
    	public Boolean isConst { get; set; }

		/// <summary>リーフ</summary>
    	public Boolean isLeaf { get; set; }

		/// <summary>純粋仮想関数（C++）</summary>
    	public Boolean isPure { get; set; }

		/// <summary>クエリー</summary>
    	public Boolean isQuery { get; set; }

		/// <summary>操作がrootであることを示すブール値</summary>
    	public Boolean isRoot { get; set; }

		/// <summary>Staticか否か</summary>
    	public Boolean isStatic { get; set; }

		/// 操作を表すEA上の型ID
    	public string objectType { get; set; }

		/// <summary>親の要素ID</summary>
    	public string parentID { get; set; }

		// <summary>事後条件</summary>
//    	public string postConditions { get; set; }

		// <summary>事前条件</summary>
//    	public string preConditions { get; set; }

		/// <summary>戻り値が配列かを示すブール値</summary>
    	public Boolean returnIsArray { get; set; }

		/// <summary>状態要素の操作に適用される追加情報</summary>
    	public string stateFlags { get; set; }

		/// <summary>スタイル(aliasが入っている？)</summary>
    	public string styleEx { get; set; }

		/// <summary>メソッドタグ付き値</summary>
    	public List<TaggedValueVO> taggedValues { get; set; }

		/// <summary>Throws句</summary>
    	public string throws { get; set; }

		/// <summary>メソッドパラメータのコレクション</summary>
    	public List<ParameterVO> parameters { get; set; }

    	public MethodVO srcMethod { get; set; }

    	public MethodVO destMethod { get; set; }

    	/// <summary>
        /// 変更有りフラグ : ' '=変更無し, C=追加(Create) U=変更(Update) D=削除(Delete)
        /// </summary>
        public char changed { get; set; }

		public MethodVO()
		{
			changed = ' ';
            taggedValues = new List<TaggedValueVO>();
		}

		public int CompareTo( MethodVO o ) {
			return ((this.pos - o.pos) == 0 ? this.name.CompareTo(o.name):(this.pos - o.pos));
		}

		// コピーを作成するメソッド
		public MethodVO Clone() {
			return (MethodVO)MemberwiseClone();
		}

        public string getComparableString()
        {
            StringWriter sw = new StringWriter();
            sw.WriteLine("name = " + name);
            sw.WriteLine("alias= " + alias);
            sw.WriteLine("guid= " + guid);
            sw.WriteLine("methodId= " + methodId);
            sw.WriteLine("elementId= " + elementId);
            sw.WriteLine("notes= " + notes);
            sw.WriteLine("behavior= " + behavior);
            sw.WriteLine("returnType= " + returnType);
            sw.WriteLine("visibility= " + visibility);
            sw.WriteLine("pos= " + pos);
            sw.WriteLine("stereoType= " + stereoType);
            sw.WriteLine("isAbstract= " + isAbstract);
            sw.WriteLine("classifierID= " + classifierID);
            sw.WriteLine("code= " + code);
            sw.WriteLine("concurrency= " + concurrency);
            sw.WriteLine("isConst= " + isConst);
            sw.WriteLine("isLeaf= " + isLeaf);
            sw.WriteLine("isPure= " + isPure);
            sw.WriteLine("isQuery= " + isQuery);
            sw.WriteLine("isRoot= " + isRoot);
            sw.WriteLine("isStatic= " + isStatic);
            sw.WriteLine("objectType= " + objectType);
            sw.WriteLine("parentID= " + parentID);
            sw.WriteLine("returnIsArray= " + returnIsArray);
            sw.WriteLine("stateFlags= " + stateFlags);
            sw.WriteLine("styleEx= " + styleEx);
            sw.WriteLine("throws= " + throws);

            if (taggedValues != null && taggedValues.Count > 0)
            {
                sw.WriteLine("taggedValues=[");
                foreach (var tv in taggedValues)
                {
                    sw.WriteLine("tv=" + tv.getComparableString() + ",");
                }
                sw.WriteLine("]");
            }

            return sw.ToString();
        }


        public string getComparedString(MethodVO o)
        {
            StringWriter sw = new StringWriter();

            if (name != o.name)
            {
                sw.WriteLine("name = " + name);
            }

            if (alias != o.alias)
            {
                sw.WriteLine("alias= " + alias);
            }

            if (guid != o.guid)
            {
                sw.WriteLine("guid= " + guid);
            }

            if (methodId != o.methodId)
            {
                sw.WriteLine("methodId= " + methodId);
            }

            if (elementId != o.elementId)
            {
                sw.WriteLine("elementId= " + elementId);
            }

            if (notes != o.notes)
            {
                sw.WriteLine("notes= " + notes);
            }

            if (behavior != o.behavior)
            {
                sw.WriteLine("behavior= " + behavior);
            }

            if (returnType != o.returnType)
            {
                sw.WriteLine("returnType= " + returnType);
            }

            if (visibility != o.visibility)
            {
                sw.WriteLine("visibility= " + visibility);
            }

            if (pos != o.pos)
            {
                sw.WriteLine("pos= " + pos);
            }

            if (stereoType != o.stereoType)
            {
                sw.WriteLine("stereoType= " + stereoType);
            }

            if (isAbstract != o.isAbstract)
            {
                sw.WriteLine("isAbstract= " + isAbstract);
            }

            if (classifierID != o.classifierID)
            {
                sw.WriteLine("classifierID= " + classifierID);
            }

            if (code != o.code)
            {
                sw.WriteLine("code= " + code);
            }

            if (concurrency != o.concurrency)
            {
                sw.WriteLine("concurrency= " + concurrency);
            }

            if (isConst != o.isConst)
            {
                sw.WriteLine("isConst= " + isConst);
            }

            if (isLeaf != o.isLeaf)
            {
                sw.WriteLine("isLeaf= " + isLeaf);
            }

            if (isPure != o.isPure)
            {
                sw.WriteLine("isPure= " + isPure);
            }

            if (isQuery != o.isQuery)
            {
                sw.WriteLine("isQuery= " + isQuery);
            }

            if (isRoot != o.isRoot)
            {
                sw.WriteLine("isRoot= " + isRoot);
            }

            if (isStatic != o.isStatic)
            {
                sw.WriteLine("isStatic= " + isStatic);
            }

            if (objectType != o.objectType)
            {
                sw.WriteLine("objectType= " + objectType);
            }

            if (parentID != o.parentID)
            {
                sw.WriteLine("parentID= " + parentID);
            }

            if (returnIsArray != o.returnIsArray)
            {
                sw.WriteLine("returnIsArray= " + returnIsArray);
            }

            if (stateFlags != o.stateFlags)
            {
                sw.WriteLine("stateFlags= " + stateFlags);
            }

            if (styleEx != o.styleEx)
            {
                sw.WriteLine("styleEx= " + styleEx);
            }

            if (throws != o.throws)
            {
                sw.WriteLine("throws= " + throws);
            }

            //sw.WriteLine("parameters= " +  parameters  );

            //sw.WriteLine("taggedValues= " + taggedValues );
            return sw.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        public void sortChildNodes()
        {
            // 子ノードを持つ項目は個別に子ノード内の子ノードソート処理を呼び出す
            for (int i = 0; i < parameters.Count; i++)
            {
                parameters[i].sortChildNodes();
            }
            
            if ( parameters != null && parameters.Count > 1)
            {
                parameters.Sort();
            }

            if (taggedValues != null && taggedValues.Count > 1)
            {
                taggedValues.Sort();
            }

        }

        public void sortChildNodesGuid()
        {
            // 子ノードを持つ項目は個別に子ノード内の子ノードソート処理を呼び出す
            for (int i = 0; i < parameters.Count; i++)
            {
                parameters[i].sortChildNodesGuid();
            }

            ParameterGuidComparer comp = new ParameterGuidComparer();
            parameters.Sort(comp);

            TaggedValueGuidComparer cmp = new TaggedValueGuidComparer();
            taggedValues.Sort(cmp);
        }

        public string getParamDesc()
        {
            StringWriter strw = new StringWriter();

            if (this.parameters != null)
            {
                for(var i=0; i < this.parameters.Count; i++ )
                {
                    ParameterVO p = this.parameters[i];
                    if (i > 0) strw.Write(", ");
                    strw.Write(p.eaType);
                }
            }

            return strw.ToString();
        }


    }


	/// <summary>
	/// Description of MethodComparer.
	/// </summary>
	public class MethodIdComparer : IComparer<MethodVO>
	{
		public MethodIdComparer()
		{
		}

	    // xがyより小さいときはマイナスの数、大きいときはプラスの数、同じときは0を返す
	    public int Compare(MethodVO x, MethodVO y)
	    {
            return x.methodId.CompareTo(y.methodId);

	    	// return x.guid.CompareTo(y.guid);
	    }
	}

    /// <summary>
    /// Description of MethodComparer.
    /// </summary>
    public class MethodGuidComparer : IComparer<MethodVO>
    {
        public MethodGuidComparer()
        {
        }

        // xがyより小さいときはマイナスの数、大きいときはプラスの数、同じときは0を返す
        public int Compare(MethodVO x, MethodVO y)
        {
            return x.guid.CompareTo(y.guid);
        }
    }


    /// <summary>
    /// Description of MethodComparer.
    /// </summary>
    public class MethodDispComparer : IComparer<MethodVO>
    {
        public MethodDispComparer()
        {
        }

        // xがyより小さいときはマイナスの数、大きいときはプラスの数、同じときは0を返す
        public int Compare(MethodVO x, MethodVO y)
        {
            return ((x.pos - y.pos) == 0 ? x.name.CompareTo(y.name) : (x.pos - y.pos));
        }

    }


}

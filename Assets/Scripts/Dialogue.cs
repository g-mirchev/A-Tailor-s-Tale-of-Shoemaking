using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue            // https://www.youtube.com/watch?v=_nRzoTzeyxU
{
    public string name;
	
	[TextArea(3, 10)]
	public string[] sentences;
}

﻿using System.Drawing;
using CTFAK.MFA;
using JFusion.ObjectTypes;

namespace JFusion;

public class JMFAObject
{
    public Color backgroundColor;
    public uint layer;
    public string name;
    public int newObjectFlags;

    public int objectFlags;
    public int objectType;
    public short[] qualifiers = new short[8];
    public int xPos;
    public int yPos;

    public static JMFAObject FromMFA(MFAObjectInstance mfaInst, MFAObjectInfo mfaObj)
    {
        var newObject = new JMFAObject();
        newObject.objectType = mfaObj.ObjectType;
        switch (mfaObj.ObjectType)
        {
            case 0: //Quick Backdrop
                break;
            case 1: //Backdrop
                break;
            case 2: //Active
                newObject = JMFAActive.FromMFA(mfaObj);
                break;
            case 3: //Text
                break;
            case 4: //Question
                break;
            case 5: //Score
                break;
            case 6: //Lives
                break;
            case 7: //Counter
                break;
            case 8: //RTF
                break;
            case 9: //SubApp
                break;
        }

        newObject.name = mfaObj.Name;
        newObject.xPos = mfaInst.X;
        newObject.yPos = mfaInst.Y;
        newObject.layer = mfaInst.Layer;

        return newObject;
    }
}
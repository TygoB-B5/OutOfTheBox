using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetActionInput : MonoBehaviour
{
    private Lamp lamp;
    private Electricalbox electricalBox;
    private Tv tv;
    private PuzzlePiece puzzlePiece;
    private Tack tack;
    private Hammer hammer;
    private Crayon crayon;
    private Antenna antenna;
    private VaultDoor vaultDoor;
    private bool isHoldingItem = false;
    void Start()
    {
        vaultDoor = FindObjectOfType<VaultDoor>();
        antenna = FindObjectOfType<Antenna>();
        hammer = FindObjectOfType<Hammer>();
        tack = FindObjectOfType<Tack>();
        puzzlePiece = FindObjectOfType<PuzzlePiece>();
        lamp = FindObjectOfType<Lamp>();
        electricalBox = FindObjectOfType<Electricalbox>();
        tv = FindObjectOfType<Tv>();
        crayon = FindObjectOfType<Crayon>();
    }
    public void ActivateAction(Transform selectedObj)
    {
        Debug.Log(selectedObj.name);

        Transform hand = GameObject.Find("Hand").transform;
        if (hand.childCount == 0)
        {
            isHoldingItem = false;
        }
        else
        {
            isHoldingItem = true;
        }

        if (selectedObj.name == "LampWire")
        {
            lamp.ClickLampWire();
        }

        if(selectedObj.name == "ElectricHandle")
        {
            electricalBox.ClickElectricalbox();
        }

        if(selectedObj.name == "Tvbutton")
        {
            tv.ClickTvButton();
        }

        if(selectedObj.name == "PuzzlePiece" && !isHoldingItem)
        {
            puzzlePiece.GetPiece();
        }

        if(selectedObj.name == "PuzzlePieceClick")
        {
            puzzlePiece.FinishPiece();
        }

        if(selectedObj.name == "Tack" && !isHoldingItem)
        {
            tack.GetTack();
        }

        if(selectedObj.name == "Australia")
        {
            tack.PlaceTack();
        }

        if (selectedObj.name == "NewTack")
        {
            tack.ResetTack();
        }

        if(selectedObj.name == "Hammer" && !isHoldingItem)
        {
            hammer.GetHammer();
        }

        if(selectedObj.name == "ElectricalBoxGlass")
        {
            hammer.BreakGlassWithHammer();
        }

        if (selectedObj.name == "Crayon" && !isHoldingItem)
        {
            crayon.GetCrayon();
        }

        if (selectedObj.name == "DrawingBoard")
        {
            crayon.ChangeNumber();
        }

        if(selectedObj.name == "CrayonHolder")
        {
            crayon.LayDownCrayon();
        }

        if(selectedObj.name == "Antenna" && !isHoldingItem)
        {
            antenna.GetAntenna();
        }

        if(selectedObj.name == "Tv")
        {
            antenna.PlaceAntenna();
        }

        if(selectedObj.name == "Submit")
        {
            vaultDoor.Submit();
        }

        if(selectedObj.name == "ClearNumpad")
        {
            vaultDoor.Clear();
        }

        for (int i = 1; i < 9; i++)
        {
            if (selectedObj.name == i.ToString())
            {
                vaultDoor.PressNumber(i);
                break;
            }
        }
        
    }

}

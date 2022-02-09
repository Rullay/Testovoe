using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DataHashing : MonoBehaviour
{

    [SerializeField] private List<int> directoryPhoneNumber;
    [SerializeField] private List<string> directoryHashing;
    [SerializeField] private GameObject InputFieldName;
    [SerializeField] private GameObject InputFieldNumber_Phone;
    [SerializeField] private Text returnNumberPhone;

    string Hashing(string _str)
    {
        string hashing = "";
        foreach (char c in _str)
        {
            hashing += "" + ((int)c);       
        }
        return hashing;
    }

    public void NewUser()
    {
        int.TryParse(InputFieldNumber_Phone.GetComponent<InputField>().text, out int number);
        string strName = InputFieldName.GetComponent<InputField>().text;

        int i = UserSearch(strName);
        if (i < 0)
        {
            directoryPhoneNumber.Add(number);
            directoryHashing.Add(Hashing(strName));
        }

 

    }

    int UserSearch(string userName)
    {
        string UserHash = Hashing(userName);
        for (int i = 0; i < directoryHashing.Count; i++)
        {
            if (UserHash == directoryHashing[i])
            {
                return i;
            }
        }

        return -1;
    }

    public void ReturnNumberOfPhone()
    {
        string userName = InputFieldName.GetComponent<InputField>().text;
        int i = UserSearch(userName);
        if (i >= 0)
        {
            returnNumberPhone.text = "" + directoryPhoneNumber[i];
        }

    }

    public void DeleteUser()
    {
        string userName = InputFieldName.GetComponent<InputField>().text;
        int i = UserSearch(userName);
        if (i >= 0)
        {
            directoryPhoneNumber.RemoveAt(i);
            directoryHashing.RemoveAt(i);
            directoryHashing.RemoveAll(x => x == null);
        }

    }


    public void EditUser()
    {
        string userName = InputFieldName.GetComponent<InputField>().text;
        int i = UserSearch(userName);
        if (i >= 0)
        {
            int.TryParse(InputFieldNumber_Phone.GetComponent<InputField>().text, out int x);
            directoryPhoneNumber[i] = x;
        }
    }


}

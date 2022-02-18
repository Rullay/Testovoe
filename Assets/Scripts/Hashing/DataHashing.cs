using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace hashtable
{
    public class DataHashing : MonoBehaviour
    {

        [SerializeField] private List<int> directoryPhoneNumber;
        [SerializeField] private List<string> directoryHashing;
        [SerializeField] private GameObject InputFieldName;
        [SerializeField] private GameObject InputFieldNumber_Phone;
        [SerializeField] private Text returnNumberPhone;
        HashTableUser hash;
        DataHashing dataHashing;
        User actualUser;




        private void Start()
        {
            hash = new HashTableUser(100);
            dataHashing = this;

        }

        public void Search(User user)
        {
            Debug.Log("" + user.Name + "    " + user.Number);
            actualUser = user;
        }

        public void AddUser()
        {
            int.TryParse(InputFieldNumber_Phone.GetComponent<InputField>().text, out int number);
            string userName = InputFieldName.GetComponent<InputField>().text;

            hash.Search(userName, dataHashing);
            if (actualUser != null)
            {
                if (actualUser.Name != userName)
                {
                    hash.Add(new User { Name = userName, Number = number });
                    Debug.Log("AddUser");
                }
            }
            else
            {
                hash.Add(new User { Name = userName, Number = number });
                Debug.Log("AddUser");
            }

          
        

        }

        public void ReturnNumberOfPhone()
        {
            string userName = InputFieldName.GetComponent<InputField>().text;
            hash.Search(userName, dataHashing);
            if (actualUser != null)
            {
                if (actualUser.Name == userName)
                {
                    returnNumberPhone.text = "" + actualUser.Number;
                    Debug.Log("ReturnNumberOfPhone");
                }
            }
       

        }

        public void DeleteUser()
        {
            string userName = InputFieldName.GetComponent<InputField>().text;
            hash.Search(userName, dataHashing);
            if (actualUser != null)
            {
                if (actualUser.Name == userName)
                {
                    hash.DeleteUser(userName);
                    Debug.Log("DeleteUser");
                }
            }
            }

            


        public void EditUser()
        {
            string userName = InputFieldName.GetComponent<InputField>().text;
            int.TryParse(InputFieldNumber_Phone.GetComponent<InputField>().text, out int number);
            hash.Search(userName, dataHashing);
            if (actualUser != null)
            {
                if (actualUser.Name == userName)
                {
                    hash.EditUser(userName, number);
                    Debug.Log("EditUser");
                }
            }
            }

          
    }
}

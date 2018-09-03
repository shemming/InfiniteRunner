using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApplicationModel : Singleton<ApplicationModel>
{
    protected ApplicationModel() {}

    public int score = 0;

}
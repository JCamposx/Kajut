using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Question
{
    public string Text;
    public List<string> Options;
    public int IndexCorrect;

    public Question()
    {
        Options = new List<string>();
    }
}

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI QuestionText;
    public TextMeshProUGUI TimerText;
    public Button ButtonOption1;
    public Button ButtonOption2;
    public Button ButtonOption3;
    public Button ButtonOption4;

    private List<Question> questions;
    private int index = 0;
    private float timer = 20f;

    // Start is called before the first frame update
    private void Start()
    {
        // 1. Create questions
        CreateQuestions();

        // 2. Load question
        LoadQuestion(index);
    }

    // Update is called once per frame
    private void Update()
    {
        if (timer < 0f)
        {
            // Time is over

            TimerText.text = "-";

            return;
        }

        TimerText.text = Mathf.RoundToInt(timer).ToString();

        timer -= Time.deltaTime;
    }

    private void CreateQuestions()
    {
        Question q1 = new Question();
        q1.Text = "Example question 1";
        q1.Options.Add("Option 1");
        q1.Options.Add("Option 2");
        q1.Options.Add("Option 3");
        q1.Options.Add("Option 4");
        q1.IndexCorrect = 1;

        Question q2 = new Question();
        q2.Text = "Example question 2";
        q2.Options.Add("Option 1");
        q2.Options.Add("Option 2");
        q2.Options.Add("Option 3");
        q2.Options.Add("Option 4");
        q2.IndexCorrect = 2;

        questions = new List<Question>();

        questions.Add(q1);
        questions.Add(q2);
    }

    private void LoadQuestion(int index)
    {
        Question question = questions[index];

        QuestionText.text = question.Text;

        TextMeshProUGUI TextButton1 = ButtonOption1
            .transform
            .Find("Text")
            .GetComponent<TextMeshProUGUI>();
        TextButton1.text = question.Options[0];

        TextMeshProUGUI TextButton2 = ButtonOption2
            .transform
            .Find("Text")
            .GetComponent<TextMeshProUGUI>();
        TextButton2.text = question.Options[1];

        TextMeshProUGUI TextButton3 = ButtonOption3
            .transform
            .Find("Text")
            .GetComponent<TextMeshProUGUI>();
        TextButton3.text = question.Options[2];

        TextMeshProUGUI TextButton4 = ButtonOption4
            .transform
            .Find("Text")
            .GetComponent<TextMeshProUGUI>();
        TextButton4.text = question.Options[4];
    }

    public void SelectOption(int option)
    {
        Question question = questions[index];

        Color color;

        if (question.IndexCorrect == option)
        {
            // Answer is correct
            color = Color.green;
        }
        else
        {
            // Answer is incorrect
            color = Color.red;
        }

        switch (option)
        {
            case 0:
                var colors = ButtonOption1.colors;
                colors.normalColor = color;
                colors.highlightedColor = color;
                colors.selectedColor = color;
                ButtonOption1.colors = colors;
                break;
            case 1:
                colors = ButtonOption2.colors;
                colors.normalColor = color;
                colors.highlightedColor = color;
                colors.selectedColor = color;
                ButtonOption2.colors = colors;
                break;
            case 2:
                colors = ButtonOption3.colors;
                colors.normalColor = color;
                colors.highlightedColor = color;
                colors.selectedColor = color;
                ButtonOption3.colors = colors;
                break;
            case 3:
                colors = ButtonOption4.colors;
                colors.normalColor = color;
                colors.highlightedColor = color;
                colors.selectedColor = color;
                ButtonOption4.colors = colors;
                break;
        }
    }
}

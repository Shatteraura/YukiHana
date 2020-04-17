using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroManager_class : MonoBehaviour
{
    public int dialogueCurrent;
    public Text introText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        clickThrough();
        introDialogue();
    }

    //Allows clicking through the intro dialogue
    void clickThrough()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dialogueCurrent++;
        }
    }

    //Contains all intro dialogue
    void introDialogue()
    {
        switch (dialogueCurrent)
        {
            case 0:
                introText.text = "Ahhhh... I finally made it here. Not gonna lie, I got pretty lucky.";
                break;

            case 1:
                    introText.text = "After graduating with a business degree from uni, I really didn't expect I would have a particularly fun job, but man was I in for a surprise!";
                    break;
                
            case 2:
                    introText.text = "An ad popped up online for an administrator for a local band called Yuki<3Hana. Looking at the report, they were already successful; all they needed was financial and admin advice.";
                    break;

            case 3:
                    introText.text = "**KNOCK KNOCK**";
                    break;
                
            case 4:
                    introText.text = "??: 'Hey, Hellooo!?'";
                    break;

            case 5:
                    introText.text = "'Come in, please!'";
                    break;

            case 6:
                    introText.text = "Two girls, huge round bellies, big bouncing breasts and nice thick thighs... Beautiful and young, breathing just a little more than usual from walking with all that weight...";
                    break;

            case 7:
                    introText.text = "Then the door opened...";
                    break;

            case 8:
                    introText.text = "??: 'Good afternoon!'";
                    break;

            case 9:
                    introText.text = "The energetic voice snapped me out of my fantasy to reveal... Two beautiful, though rather less heavy girls.";
                    break;

            case 10:
                    introText.text = "'Welcome girls, a pleasure to make your acquaintance'";
                    break;

            case 11:
                    introText.text = "What on earth was I thinking? These two are idols, no way they would be anywhere close to overweight! Ah well, they sure are pretty at least.";
                    break;

            case 12:
                    introText.text = "I suppress a slight chuckle and move over to shake their hands.";
                    break;

            case 13:
                    introText.text = "Yuki: 'Pleasure's all ours Mr. Manager! Pleased to meet you, I'm Yuki and this is Hana.'";
                    break;

            case 14:
                    introText.text = "Hana: 'Good afternoon Sir. We look forward to working with you.'";
                    break;

            case 15:
                    introText.text = "Some time later...";
                    break;

            case 16:
                    introText.text = "Alright, looks like we are all set; I've taken control of the business account and bookings for the studio and concert hall...";
                    break;

            case 17:
                    introText.text = "Hana: 'We have transferred partial control of our social media to you as well Sir.'";
                    break;

            case 18:
                    introText.text = "Yuki: 'This is gonna be awesome!Thanks so much Mr.Manager, we could never have gotten all this organised with all our rehersal and studio time.'";
                    break;
                
            case 19:
                
                    introText.text = "Hana: 'I think a celebration is in order!'";
                    break;

            case 20:
                    introText.text = "Couldn't have said it better myself! Let's head out!";
                    break;

            case 21:
                    introText.text = "We walked together though the town center Yuki excitedly pointed out useful areas including the location of the main concert hall. Hana walked near silently beside us, occasionally giving me a knowing and friendly smile.";
                    break;

            case 22:
                    introText.text = "Finally the girls stop outside of a selection of restaurants and begin to whisper to each other.";
                    break;

            case 23:
                    introText.text = "'Whats up, want to eat here?'";
                    break;

            case 24:
                    introText.text = "Both girls glance at each other and then back at me...";
                    break;

            case 25:
                    introText.text = "Yuki: 'We would love to but this is an all you can eat place, I'm kinda worried we would overdo it a little *Haha*'";
                    break;

            case 26:
                    introText.text = "Hana: 'We do have to think of our weight a little after all *Giggle*'";
                    break;
                
            case 27:
                    introText.text = "'And here I thought idols subsisted on one glass of water a day!'";
                    break;

            case 28:
                    introText.text = "H&Y: '*Giggling*'";
                    break;

            case 29:
                    introText.text = "'I'm sure it's fine girls, no problem with treating yourselves once in a while.'";
                    break;

            case 30:
                    introText.text = "Hana: 'Let's do it, it should be pretty fun since we don't get to do this often.'";
                    break;

            case 31:
                    introText.text = "About an hour later...";
                    break;

            case 32:
                    introText.text = "Yuki: 'Ughhh...I'm gonna burst...'";
                    break;

            case 33:
                    introText.text = "Hana: 'Ahha...Oof...Yeah we...Overdid it...'";
                    break;

            case 34:
                    introText.text = "That was pretty incredible, I would ask where they put it all but that would be an odd question with how round and stretched their bellies look.";
                    break;

            case 35:
                    introText.text = "These two have a serious gluttonous streak! I can't help but wonder if I can coax it out of them more often...";
                    break;

            case 36:
                    introText.text = "Obviously their careers come first. I'm not about to let them down after all! Still... Maybe that fantasy of mine isn't too far fetched after all?";
                    break;
                

            case 37:
                SceneManager.LoadScene("Game", LoadSceneMode.Single);
                    break;
                
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary3Word : MonoBehaviour
{
 
    public string[] WordDictionary;
    private string RawWord =
    "AAHAALAASABAABSABYACEACTADDADOADSADZAFFAFTAGAAGEAGOAGSAHAAHIAHSAIDAILAIMAINAIRAISAITALAALBALEALLALPALSALTAMAAMIAMPAMUANAANDANEANIANTANYAPEAPOAPPAPTARBARCAREARFARKARMARSARTASHASKASPATEATTAUKAVAAVEAVOAWAAWEAWLAWNAXEAYEAYSAZOBAABADBAGBAHBALBAMBANBAPBARBASBATBAYBEDBEEBEGBELBENBESBETBEYBIBBIDBIGBINBIOBISBITBIZBOABOBBODBOGBOOBOPBOSBOTBOWBOXBOYBRABROBRRBUBBUDBUGBUMBUNBURBUSBUTBUYBYEBYSCABCADCAMCANCAPCARCATCAWCAYCEECELCEPCHICIGCISCOBCODCOGCOLCONCOOCOPCORCOSCOTCOWCOXCOYCOZCRUCRYCUBCUDCUECUMCUPCURCUTCWMDABDADDAGDAHDAKDALDAMDANDAPDAWDAYDEBDEEDEFDELDENDEVDEWDEXDEYDIBDIDDIEDIFDIGDIMDINDIPDISDITDOCDOEDOGDOLDOMDONDORDOSDOTDOWDRYDUBDUDDUEDUGDUHDUIDUNDUODUPDYEEAREATEAUEBBECUEDHEDSEEKEELEFFEFSEFTEGGEGOEKEELDELFELKELLELMELSEMEEMSEMUENDENGENSEONERAEREERGERNERRERSESSETAETHEVEEWEEYEFABFADFANFARFASFATFAXFAYFEDFEEFEHFEMFENFERFESFETFEUFEWFEYFEZFIBFIDFIEFIGFILFINFIRFITFIXFIZFLUFLYFOBFOEFOGFOHFONFOPFORFOUFOXFOYFROFRYFUBFUDFUGFUNFURGABGADGAEGAGGALGAMGANGAPGARGASGATGAYGEDGEEGELGEMGENGETGEYGHIGIBGIDGIEGIGGINGIPGITGNUGOAGOBGOOGORGOSGOTGOXGOYGULGUMGUNGUTGUVGUYGYMGYPHADHAEHAGHAHHAJHAMHAOHAPHASHATHAWHAYHEHHEMHENHEPHERHESHETHEWHEXHEYHICHIDHIEHIMHINHIPHISHITHMMHOBHODHOEHOGHONHOPHOSHOTHOWHOYHUBHUEHUGHUHHUMHUNHUPHUTHYPICEICHICKICYIDSIFFIFSIGGILKILLIMPINKINNINSIONIREIRKISMITSIVYJABJAGJAMJARJAWJAYJEEJETJEUJEWJIBJIGJINJOBJOEJOGJOTJOWJOYJUGJUNJUSJUTKABKAEKAFKASKATKAYKEAKEFKEGKENKEPKEXKEYKHIKIDKIFKINKIPKIRKISKITKOAKOBKOIKOPKORKOSKUEKYELABLACLADLAGLAMLAPLARLASLATLAVLAWLAXLAYLEALEDLEELEGLEILEKLESLETLEULEVLEXLEYLEZLIBLIDLIELINLIPLISLITLOBLOGLOOLOPLOTLOWLOXLUGLUMLUVLUXLYEMACMADMAEMAGMANMAPMARMASMATMAWMAXMAYMEDMEGMELMEMMENMETMEWMHOMIBMICMIDMIGMILMIMMIRMISMIXMOAMOBMOCMODMOGMOLMOMMONMOOMOPMORMOSMOTMOWMUDMUGMUMMUNMUSMUTMYCNABNAENAGNAHNAMNANNAPNAWNAYNEBNEENEGNETNEWNIBNILNIMNIPNITNIXNOBNODNOGNOHNOMNOONORNOSNOTNOWNTHNUBNUNNUSNUTOAFOAKOAROATOBAOBEOBIOCAODAODDODEODSOESOFFOFTOHMOHOOHSOILOKAOKEOLDOLEOMSONEONOONSOOHOOTOPEOPSOPTORAORBORCOREORSORTOSEOUDOUROUTOVAOWEOWLOWNOXOOXYPACPADPAHPALPAMPANPAPPARPASPATPAWPAXPAYPEAPECPEDPEEPEGPEHPENPEPPERPESPETPEWPHIPHTPIAPICPIEPIGPINPIPPISPITPIUPIXPLYPODPOHPOIPOLPOMPOOPOPPOTPOWPOXPROPRYPSIPSTPUBPUDPUGPULPUNPUPPURPUSPUTPYAPYEPYXQATQISQUARADRAGRAHRAIRAJRAMRANRAPRASRATRAWRAXRAYREBRECREDREEREFREGREIREMREPRESRETREVREXRHORIARIBRIDRIFRIGRIMRINRIPROBROCRODROEROMROTROWRUBRUERUGRUMRUNRUTRYARYESABSACSADSAESAGSALSAPSATSAUSAWSAXSAYSEASECSEESEGSEISELSENSERSETSEWSHASHESHHSHYSIBSICSIMSINSIPSIRSISSITSIXSKASKISKYSLYSOBSODSOLSOMSONSOPSOSSOTSOUSOWSOXSOYSPASPYSRISTYSUBSUESUKSUMSUNSUPSUQSYNTABTADTAETAGTAJTAMTANTAOTAPTARTASTATTAUTAVTAWTAXTEATEDTEETEGTELTENTETTEWTHETHOTHYTICTIETILTINTIPTISTITTODTOETOGTOMTONTOOTOPTORTOTTOWTOYTRYTSKTUBTUGTUITUNTUPTUTTUXTWATWOTYEUDOUGHUKEULUUMMUMPUNSUPOUPSURBURDURNURPUSEUTAUTEUTSVACVANVARVASVATVAUVAVVAWVEEVEGVETVEXVIAVIDVIEVIGVIMVISVOEVOWVOXVUGVUMWABWADWAEWAGWANWAPWARWASWATWAWWAXWAYWEBWEDWEEWENWETWHAWHOWHYWIGWINWISWITWIZWOEWOKWONWOOWOSWOTWOWWRYWUDWYEWYNXISYAGYAHYAKYAMYAPYARYAWYAYYEAYEHYENYEPYESYETYEWYINYIPYOBYODYOKYOMYONYOUYOWYUKYUMYUPZAGZAPZASZAXZEDZEEZEKZEPZIGZINZIPZITZOAZOOZUZZZZ";
    public void Awake()
    {
        int WordCount = 0;
        string CutString = "";
        for (int i = 0; i < RawWord.Length; i++)
        {
            CutString = CutString + RawWord[i];
           
            if (CutString.Length==3)
            {

                WordDictionary.SetValue(CutString,WordCount);
               
                WordCount++;
                CutString = "";
            }
          
        }

    }
    public string GetRandomWord()
    {
      
        int RandomIndex = Random.Range(0, WordDictionary.Length);
        string Word;
        Word = WordDictionary[RandomIndex];
   
        return Word;
    }
}
# About Finding Alice :rabbit2:   

***
## Finding Alice 소개
***
- **프로젝트 이름**: Finding Alice   
- **기간**: 2022.04.06 ~ ing
- **간단한 설명**: `Finding Alice`는 약간의 컨트롤을 요구하는 2.5D 횡스크롤 모바일 게임입니다.
달나라 토끼의 주 업무는 맛있는 떡을 만드는 것! 이지만…. 주인공 토끼(플레이어)는 `이상한 나라의 앨리스`를 읽고 시계 토끼를 동경하게 되어 앨리스를 찾아 지구로 떠나게 되었습니다. 지구에 도착했지만 다양한 동화 속 인물들의 사건을 해결해야만 앨리스를 찾을 수 있으며, 주인공은 `도약이 가능한 회중시계`를 이용해 사건을 해결해 나갈 수 있습니다.   
- **플랫폼**: Android :iphone:    
- **장르**: `2.5D 횡스크롤 와이어 액션 플랫포머` 게임  

***
## Finding Alice 챕터
***

- **튜토리얼** :arrow_forward:
[튜토리얼에 대한 주요 기능 설명]

- **챕터 1** :deciduous_tree:
[챕터 1에 대한 주요 기능 설명]

- **챕터 2** :fish:
>>* 챕터 1에도 등장한 Transparent 플랫폼이 등장합니다.     
>>* 이안류 기믹   
>>   * Player와 닿는 동안 한 쪽 방향으로 플레이어를 6의 속도로 밀어냅니다.   
>>   * 이안류 기믹은 시계로 빠져나올 수 있습니다.   
>>* 작은 동굴   
>>   * 모든 추격 기믹이 멈추는 안전 지대   
>>* 복어 공격   
>>* 해파리 공격   
>>   * 위아래로 이동하는 해파리가 플레이어를 공격합니다.   
>>* 곰치 공격   
>>   * 숨어있던 곰치가 튀어나와 공격합니다.   
>>* 청새치 돌진(추격 기믹 1)   
>>   * 플레이어를 향해 물고기가 돌진합니다.   
>>* 전원 돌격(추격 기믹 2)   
>>   * 플레이어가 마지막으로 있었던 Y축 위치에서 가로로 길게 지속적으로 광역 공격을 당합니다.   

- **챕터 3** :spades:
[챕터 3에 대한 주요 기능 설명]

***
## Finding Alice 이미지
***

- **튜토리얼 이미지**   
![튜토리얼](https://github.com/Gyuri0315/FindingAlice/assets/122785488/b9e5448f-95e9-4ebe-97b2-7d5ea64cc1a0)   

- **챕터 1 이미지**   
![1장](https://github.com/Gyuri0315/FindingAlice/assets/122785488/a52fbb15-6a47-42a2-abf2-24f8c0164a96)   

- **플랫폼 이미지**   
![플랫폼](https://github.com/Gyuri0315/FindingAlice/assets/122785488/20389222-d7bb-4fd6-8fa2-a79adba3d763)   

- **캐릭터 스프라이트 이미지**   
![캐릭터 스프라이트](/Deck/Rabbit_Sprite.PNG)   

- **아이템 이미지**   
![아이템1](https://github.com/Gyuri0315/FindingAlice/assets/122785488/ea293676-843e-431e-9054-4e89c34933fe)      
![아이템2](https://github.com/Gyuri0315/FindingAlice/assets/122785488/79174668-d81c-463d-90ca-e8284bf91b65)   
![아이템3](https://github.com/Gyuri0315/FindingAlice/assets/122785488/1f2a926f-0e0f-4497-8685-fd1fa4356091)   


***   
## Finding Alice 스크립팅   
***

- **파인딩앨리스 주요 스크립트**
[주요 스크립트에 대한 설명]

- **코드 스타일 가이드 라인**   
* **클래스**    
클래스의 이름은 파스칼 표기법 사용 (예: AxisTouchButton, GameManager)   
접근 지정자(public, private, 등) 항상 표기   

* **변수 (Variables)**    
변수 이름은 카멜 표기법 사용 (예: axisName, responseSpeed)   
변수는 기능별로 정렬   

* **함수 (Methods):**   
함수의 이름은 카멜 케이스(CamelCase)를 사용합니다. (예: OnPointerDown, FindPairedButton)   
   
>```
> //사용예시
>private void Update()
>    {
>        if (Input.GetKeyDown(KeyCode.R))
>        {
>            SceneManager.LoadScene("Chapter_1");
>        }
>    }
>```



***
## Pages
***
- **파인딩앨리스 설문조사 링크**: [링크](https://docs.google.com/forms/d/e/1FAIpQLScKXSLZwnU7ZOz2QlLN3dmoqAGOPZDtzA7EsF5PSpt_eQ7j4g/viewform?usp=sharing)
- **파인딩앨리스 기획서 Notion Page**: [링크](https://absorbed-splash-9bb.notion.site/a1834c6a357d4bfe84a5722cd9f11c60)

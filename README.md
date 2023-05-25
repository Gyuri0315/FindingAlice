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
>>* 파인딩 앨리스의 기본적인 기능을 익힙니다.
>>  * 시계, 점프 등

- **챕터 1** :deciduous_tree:
>>  * 밟으면 일정 시간 후 사라지는 DisappearPlatform이 등장합니다.
>>  * 닿으면 죽는 die오브젝트가 등장합니다.
>>  * Transparent 플랫폼이 등장합니다. 
>>  * 모래시계가 등장합니다.
>>    * 아이템을 획득하면 시계의 개수가 늘어납니다. 
>>  * PassingPlatform 플랫폼이 등장합니다.  
>>    * 플레이어는 이 플랫폼을 통과할 수 있습니다.

- **챕터 2** :fish:
>>  * 플레이어가 수영을 하여 무한 점프가 가능해집니다.
>>  * 플레이어의 하강 속도와 이동 속도가 감소합니다.
>>  * 챕터 1에도 등장한 Transparent 플랫폼이 등장합니다.  
>>  * 물속에서 진행되므로 플레이어는 산소 공급재로 산소를 계속 회복하여 주어야 합니다.   
>>  * 이안류 기믹   
>>    * Player와 닿는 동안 한 쪽 방향으로 플레이어를 6의 속도로 밀어냅니다.   
>>    * 이안류 기믹은 시계로 빠져나올 수 있습니다.   
>>  * 작은 동굴   
>>    * 모든 추격 기믹이 멈추는 안전 지대   
>>  * 복어 공격   
>>  * 해파리 공격   
>>    * 위아래로 이동하는 해파리가 플레이어를 공격합니다.   
>>  * 곰치 공격   
>>    * 숨어있던 곰치가 튀어나와 공격합니다.   
>>  * 청새치 돌진(추격 기믹 1)   
>>    * 플레이어를 향해 물고기가 돌진합니다.   
>>  * 전원 돌격(추격 기믹 2)   
>>    * 플레이어가 마지막으로 있었던 Y축 위치에서 가로로 길게 지속적으로 광역 공격을 당합니다.   
>>  * die 플랫폼이 사라집니다.

- **챕터 3** :spades:
>>  * 플레이어의 하강 속도와 이동 속도가 챕터 1처럼 롤백됩니다.
>>  * 추가 도약
>>    * 시계 사용 후 추가로 점프할 수 있는 시스템
>>  * 숨고르기
>>    * 아무 플랫폼 위에 플레이어가 계속 있으면 시계 횟수가 충전되는 시스템
>>  * 영지 침범
>>    * 여왕의 영지에 초대 받지 않은 모든 이들은 각자의 능력에 따라 저주를 받는다.

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
      * 파스칼 표기법 사용 (예: AxisTouchButton, GameManager)   
      * 접근 지정자(public, private, 등) 항상 표기하기   

   * **변수**    
      * 카멜 표기법 사용 (예: axisName, responseSpeed)   
      * 변수는 기능별로 정렬하기   

   * **함수**   
      * 파스칼 표기법 사용 (예: OnPointerDown, FindPairedButton)   
   
>>>```C#
>>> //사용예시(아래 형식으로 쓸 것)
>>>private void Update()
>>>    {
>>>        if (Input.GetKeyDown(KeyCode.R))
>>>        {
>>>            SceneManager.LoadScene("Chapter_1");
>>>        }
>>>    }
>>>```



***
## Pages
***
- **파인딩앨리스 설문조사 링크**: [링크](https://docs.google.com/forms/d/e/1FAIpQLScKXSLZwnU7ZOz2QlLN3dmoqAGOPZDtzA7EsF5PSpt_eQ7j4g/viewform?usp=sharing)
- **파인딩앨리스 기획서 Notion Page**: [링크](https://absorbed-splash-9bb.notion.site/a1834c6a357d4bfe84a5722cd9f11c60)

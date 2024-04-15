# C# TeamProject

## 프로젝트 명

**Midnight Mafia - 마피아 게임**

## 프로젝트 주제

여러 유저들이 통신하여 ‘마피아 게임’을 할 수 있는 응용 소프트웨어를 개발합니다.

기본적은 규칙은 기존 마피아 게임의 규칙을 따르며 게임에 더욱 몰두할 수 있는 UI를 제공합니다.

## 프로젝트 주요 기능

1. 입장전 닉네임 입력

 대기실 입장하면 위에 입력한 텍스트를 이름으로 설정합니다.

 User3428와 같이 난수값으로 default 설정합니다.

![1. 입장전_닉네임입력.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/a0050bf9-5a91-46b8-b21b-40419b01b83b/76588e7d-45b1-4b1a-9d2a-e02de86972fc/a310c80f-4fba-4c57-aa37-3e5f55dd01c0.png)

2. 대기실

 대기실에 유저가 들어오면 설정한 닉네임과 대기실에 있는 유저수가 표시됩니다.

 최대인원인 4명이 접속하면 자동으로 게임을 시작합니다.

![2. 대기실.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/a0050bf9-5a91-46b8-b21b-40419b01b83b/66e9e865-11f9-49e6-a45c-ec68a3aff03f/653e286d-0094-4dcf-9e44-91601692c94c.png)

3. 밤: 역할 분배

 게임을 시작하면 랜덤하게 사용자에게 직업이 주어지며, 각 유저 개개인의 직업에 해당하는 카드와 설명이 포시됩니다.

![3. 밤 - 역할 분배.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/a0050bf9-5a91-46b8-b21b-40419b01b83b/7d49b216-1b01-4414-8e5a-5bc968dc56a2/46e57bba-4e5d-4ed8-8e86-3b0b4efbee79.png)

4. 밤: 역할별 화면
- 인터페이스: 좌상단에는 몇번째 밤인지 표시되며 우상단에는 밤이 얼마나 남았는지 타이머가 표시됩니다.
- 시민
    - 경찰과 마피아의 턴이 끝날 때까지 대기하라는 문구창이 표시됩니다.

![3-1. 밤 - 시민.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/a0050bf9-5a91-46b8-b21b-40419b01b83b/fd188bca-6dcc-4216-9b17-e928d8f8db18/315520d3-78bf-421a-9ce6-abdd43faa58a.png)

- 마피아
    - 살해할 유저를 선택하는 창이 표시됩니다. 미선택을 방지하기 위해 기본적으로 첫번째 유저가 선택되어 있습니다.
    - 클릭(or방향키)으로 살해할 유저를 선택한 후, “선택” 버튼을 누르면 확정됩니다.

![3-3. 밤 - 마피아.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/a0050bf9-5a91-46b8-b21b-40419b01b83b/89eaafad-acf7-409c-aa18-03f06fcbb77b/76e5b79b-c78f-4a5f-81c1-aa92127e97e4.png)

- 경찰
    - 조사할 유저를 선택하는 창이 뜹니다. 미선택을 방지하기 위해 기본적으로 첫번째 유저가 선택되어 있습니다.
    - 클릭(or방향키)으로 조사할 유저를 선택한 후, “선택” 버튼을 누르면 확정됩니다.
    - 선택 버튼을 누르면 해당 유저의 마피아 여부를 알 수 있습니다.

![3-2. 밤 - 경찰.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/a0050bf9-5a91-46b8-b21b-40419b01b83b/b058d7a0-9faf-4f87-8645-3929696801ff/d04eea07-cfe1-4966-96e3-57c23af28a9b.png)

5. 살해당한 사람 공개

 밤이 종료되면 낮 화면 인터페이스로 전환되며, 밤에 살해당한 유저에 대한 안내문구창이 표시됩니다.

 낮 화면 인터페이스는 좌상단에 몇번째 낮인지 표기되며, 우상단에는 낮시간이 얼마나 남았는지 표시됩니다.

![4. 살해당한 사람 공개.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/a0050bf9-5a91-46b8-b21b-40419b01b83b/63801fe2-b7a9-40f4-acf4-e960369d30f1/4._%EC%82%B4%ED%95%B4%EB%8B%B9%ED%95%9C_%EC%82%AC%EB%9E%8C_%EA%B3%B5%EA%B0%9C.png)

6. 낮: 참여자 소통

 유저들간의 채팅이 가능합니다.

 하단에 있는 채팅창에 채팅을 입력한 후 “send” 버튼을 누르면 사용자의 입력값이 전송됩니다.

[]()

7. 낮: 투표시간

 참여자끼리의 소통시간이 종료되면 투표시간으로 좌상단 문구가 변경되며 타이머또한 투표시간에 맞춰 재설정됩니다.

 유저의 닉네임 옆에 있는 체크칸을 누르면 해당 유저를 선택하게 됩니다. 선택은 한명만 할 수 있고 바꿀 수 있습니다. 투표하기를 누르면 체크한 유저에 대해 투표를 확정하게 됩니다.

![6. 낮 - 투표.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/a0050bf9-5a91-46b8-b21b-40419b01b83b/e4ec3577-1eb9-4c9a-a4be-99f060aa3c27/644a0e68-8484-409a-88ac-04a6ca173ea0.png)

8. 낮: 최후의 발언(개발 후순위)

 투표시간이 종료되면 좌상단 문구가 ‘최후의 발언’으로 바뀌며 타이머도 최후의 발언 시간에 맞춰 재설정되고 투표시간에 최다 득표를 받은 유저가 최후의 발언을 할 수 있는 창이 표시됩니다.

 채팅은 최다 득표자만 전송 수 있으며 나머지 유저에게는 채팅을 보는 기능만 제공합니다. 

![7-2. 낮 - 최후의 발언(발언자).png](https://prod-files-secure.s3.us-west-2.amazonaws.com/a0050bf9-5a91-46b8-b21b-40419b01b83b/99c5483b-2bed-47d6-9faa-c17fd8b90797/f98fb3a1-3356-43e4-9f97-b82fde05a645.png)

![7-1. 낮 - 최후의 발언.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/a0050bf9-5a91-46b8-b21b-40419b01b83b/84961471-eacd-4c9a-89c2-d94d16db797e/c8cd31c4-246f-4dd4-a081-1595481c0117.png)

9. 투표 처형자 공개

 최다 득표를 받은 유저가 처형당했다는 문구와 함께 해당 유저의 직업을 알려주는 창이 표시됩니다.

![8. 투표 처형자 공개.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/a0050bf9-5a91-46b8-b21b-40419b01b83b/2d602d19-e7ba-447a-b888-8effd6efb20e/8._%ED%88%AC%ED%91%9C_%EC%B2%98%ED%98%95%EC%9E%90_%EA%B3%B5%EA%B0%9C.png)

10. 게임종료

 게임이 종료되면 어느팀이 이겼는지 문구가 뜨게 되고 모든 유저의 직업을 텍스트로 알려줍니다.

 로비로 돌아가기 버튼을 누르면 대기실로 돌아가고 종료하기 버튼을 누르면 게임이 종료됩니다.

![9-1. 게임종료.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/a0050bf9-5a91-46b8-b21b-40419b01b83b/19e4b9ec-36b6-4612-b531-0eca7b8205eb/ff42aa90-07d2-447c-b91c-9193a109d475.png)

![9-2. 게임종료_시민팀승리.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/a0050bf9-5a91-46b8-b21b-40419b01b83b/dd509ad2-90bd-402c-a59c-36ce971d58d6/1aaf1836-d9e0-4360-81e3-21d00c7f7f88.png)

## 프로젝트 진행 계획

[프로젝트 진행 계획](https://www.notion.so/183435dafc03423999fa46591aca0de0?pvs=21)

## Developers

<table>
    <thead>
        <tr>
            <th style="text-align:center;"><a href="https://github.com/Eunjin03">오은진</a></th>
            <th style="text-align:center;"><a href="https://github.com/gusrns48">강현구</a></th>
            <th style="text-align:center;"><a href="https://github.com/YuJin020303">이유진</a></th>
            <th style="text-align:center;"><a href="https://github.com/G0MTENG">공태윤</a></th>
            
        </tr>
    </thead>
    <tbody>
        <tr>
            <td><img src="https://avatars.githubusercontent.com/u/115154546?v=4" width="120"/></td>
            <td><img src="https://avatars.githubusercontent.com/u/49228161?v=4" width="120"/></td>
            <td><img src="https://avatars.githubusercontent.com/u/84318474?v=4" width="120"/></td>
            <td><img src="https://avatars.githubusercontent.com/u/106204894?v=4" width="120"/></td>
        </tr>
        <tr>
            <td style="text-align:center;">Project총괄, PM팀장, BE</td>
            <td style="text-align:center;">BE팀장</td>
            <td style="text-align:center;">Design팀장, FE</td>
            <td style="text-align:center;">FE팀장</td>
        </tr>
    </tbody>
</table>



import { Component, OnInit } from '@angular/core';
import {Member} from "../../Models/member";
import {User} from "../../Models/User";
import {AccountService} from "../../_services/account.service";
import {MembersService} from "../../_services/members.service";
import {take} from "rxjs/operators";

@Component({
  selector: 'app-member-edit',
  templateUrl: './member-edit.component.html',
  styleUrls: ['./member-edit.component.css']
})
export class MemberEditComponent implements OnInit {
  member:Member;
  user:User;


  constructor(private accountService : AccountService, private memberService : MembersService) {

    this.accountService.currentUser$.pipe(take(1)).subscribe(user => this.user = user);
  }

  ngOnInit(): void {
    this.loadMember();
  }

  loadMember(){
    this.memberService.getMember(this.user.username).subscribe(member => this.member = member);
  }

}

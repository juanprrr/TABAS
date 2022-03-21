import { Component, OnInit } from '@angular/core';
import {Router } from '@angular/router';

@Component({
  selector: 'app-mainmenu',
  templateUrl: './mainmenu.component.html',
  styleUrls: ['./mainmenu.component.css']
})
export class MainmenuComponent implements OnInit {

  ngOnInit(): void {
  }

  constructor(private router: Router){
  }

  goToPage(pageName:string){
    this.router.navigate([`${pageName}`]);
  }

}

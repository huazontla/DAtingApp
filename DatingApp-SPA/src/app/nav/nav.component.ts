import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  // this will store our username and password
  model: any  = {};

  constructor(private authService: AuthService) { }

  ngOnInit() {
  }

  login(){
    this.authService.login(this.model).subscribe(next => {
      console.log('Logueado correctamente');
    }, error => {
      console.log(error);
    });
  }

  loggedIn(){
    const token = localStorage.getItem('token');

    return !!token; // if this token variable is empty then it's going to return false
  }

  loggedOut(){
    localStorage.removeItem('token');
    console.log('logged out');
  }

}

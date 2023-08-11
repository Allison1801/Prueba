import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedComponent } from './shared.component';
import { AppRoutingModule } from '../app-routing.module';



@NgModule({
  declarations: [SharedComponent],
  imports: [
    CommonModule,
    AppRoutingModule
  ],
  exports:[
    SharedComponent
  ]
})
export class SharedModule { }

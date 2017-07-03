import { MakeService } from './../../services/make.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
  makes;
  constructor(private makeService: MakeService) { }

  ngOnInit() {
    console.log("MAKES",this.makes);

    this.makeService.getMakes().subscribe(makes => {
      this.makes = makes
      //log para confirmar se esta td certo ate aqiu 
      console.log("MAKES",this.makes);
    });
  }

}

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AdsService } from '../services/ads.service';

@Component({
  selector: 'app-create-ad',
  templateUrl: './create-ad.page.html',
  styleUrls: ['./create-ad.page.scss'],
})
export class CreateAdPage implements OnInit {

  private addFile: any;
  private addFileName: string;
  private createAd: FormGroup;

  constructor(
    private adsService: AdsService,
    private formBuilder: FormBuilder
  ) {
    this.createAd = this.formBuilder.group({
      title      : ['', Validators.required],
      description: ['', Validators.required],
      author     : ['', Validators.required],
      isbn       : ['', Validators.required],
      college    : ['', Validators.required],
      rate       : ['', Validators.required],
    });
  }

  ngOnInit() {
  }

  // onFileChange(event) {
  //   var file: File = event.target.files[0];
  //   var reader = new FileReader();
  //   reader.onloadend = () => {
  //       console.log('RESULT', reader.result)
  //       const blobFile = new Blob([reader.result], { type: file.type });
  //       this.addFile = blobFile;
  //       this.addFileName = file.name;
  //   }
  //   reader.readAsArrayBuffer(file);
  // }

  onFileChange(event) {
    var file: File = event.target.files[0];
    console.log( file );
    var reader = new FileReader();
    reader.onloadend = () => {
        // console.log('RESULT', reader.result)
        // const blobFile = new Blob([reader.result], { type: file.type });
        this.addFile = reader.result;
        this.addFileName = file.name;
    }
    reader.readAsDataURL(file);
  }

  addAd() {
    console.log('--'+ 'test' +'--', this.addFile, this.addFileName);
    this.adsService.Create({
      Title: this.createAd.get('title').value,
      Description: this.createAd.get('description').value,
      Author: this.createAd.get('author').value,
      ISBN: this.createAd.get('isbn').value,
      College: this.createAd.get('college').value,
      Rate: this.createAd.get('rate').value,
      ImagePath: this.addFile
    })
  }

}

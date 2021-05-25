<?php

namespace App\Http\Resources;

use Illuminate\Http\Resources\Json\JsonResource;

class Interest extends JsonResource
{
    /**
     * Transform the resource into an array.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return array
     */
    public function toArray($request)
    {
        return [
            'id' => $this->id,
            'interest'=>$this->interest,           
            'user'=>$this->user
        ];
    }
    public function show(Interest $interest)
    {
        return $interest;
    }
}

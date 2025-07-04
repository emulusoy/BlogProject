﻿using BlogProject.BusinessLayer.Abstract;
using BlogProject.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.PresentationLayer.Controllers
{
    public class AdminSliderController : Controller
    {
        private readonly ISliderService _sliderService;

        public AdminSliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public IActionResult SliderList()
        {
            var values = _sliderService.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSlider()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSlider(Slider slider)
        {
            _sliderService.TInsert(slider);
            return RedirectToAction("SliderList");
        }
        public IActionResult DeleteSlider(int id)
        {
            _sliderService.TDelete(id);
            return RedirectToAction("SliderList");
        }
        [HttpGet]
        public IActionResult UpdateSlider(int id)
        {
            var value = _sliderService.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateSlider(Slider slider)
        {
            _sliderService.TUpdate(slider);
            return RedirectToAction("SliderList");
        }
    }
}
